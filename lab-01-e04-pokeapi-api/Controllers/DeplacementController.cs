using lab_01_e04_pokeapi_api.Data.Context;
using lab_01_e04_pokeapi_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

[Route("api/[controller]")]
[ApiController]
public class DeplacementController : ControllerBase
{
    private readonly PokeContext _context;
    public DeplacementController(PokeContext context)
    {
        _context = context;
    }

    private bool DeplacementPossible(int pX, int pY, int destiX, int destiY)
    {
        int depX = pX - destiX;
        int depY = pY - destiY;

        return ((depX != depY && depX != -depY) && (depX == 1 || depX == 0 || depX == -1) && (depY == 1 || depY == 0 || depY == -1));
    }

    [HttpGet("{idPersonnage:int}/{x:int}/{y:int}")]
    public async Task<ActionResult<DeplacementResult>> AutourJoueur(int idPersonnage, int x, int y)
    {
        string? idUser = HttpContext.Session.GetString("SessionConnexion");
        if (idUser != null)
        {
            Personnage? personnage = await _context.Personnages.Include(p => p.UtilisateurId).FirstOrDefaultAsync(p => p.IdPersonnage == idPersonnage);

            if (personnage != null && personnage.UtilisateurId.IdUtilisateur == idUser)
            {
                if (!(x < Tuile.MIN || x > Tuile.MAX || y < Tuile.MIN || y > Tuile.MAX)
                    && DeplacementPossible(personnage.PositionX, personnage.PositionY, x, y))
                {
                    try
                    {
                        var destination = await _context.Tuiles.FirstOrDefaultAsync(t => t.PositionX == x && t.PositionY == y);

                        if (destination != null && destination.EstTraversable)
                        {
                            int xMin = Math.Max(x - 1, Tuile.MIN);
                            int yMin = Math.Max(y - 1, Tuile.MIN);

                            int xMax = Math.Min(x + 1, Tuile.MAX);
                            int yMax = Math.Min(y + 1, Tuile.MAX);

                            var tuiles = await _context.Tuiles
                            .Where(t => t.PositionX >= xMin && t.PositionX <= xMax
                                     && t.PositionY >= yMin && t.PositionY <= yMax)
                            .OrderBy(t => t.PositionY)
                            .ThenBy(t => t.PositionX)
                            .ToListAsync();
                            personnage.PositionX = x;
                            personnage.PositionY = y;
                            await _context.SaveChangesAsync();
                            //List<int> tuilesResult = new List<int>();
                            //tuiles.ForEach(t => {
                            //    tuilesResult.Add(t.PositionX);
                            //});
                            return new DeplacementResult()
                            {
                                EstValide = true,
                                FinalX = personnage.PositionX,
                                FinalY = personnage.PositionY,
                                Tuiles = tuiles
                            };
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        return new DeplacementResult()
                        {
                            EstValide = false,
                            FinalX = personnage.PositionX,
                            FinalY = personnage.PositionY,
                            Tuiles = null
                        };
                    }
                }
                else
                {
                    return new DeplacementResult()
                    {
                        EstValide = false,
                        FinalX = personnage.PositionX,
                        FinalY = personnage.PositionY,
                        Tuiles = null
                    };
                }
            }
            else return BadRequest("Mauvais User");
        }
        return Unauthorized("Session absente ou expirée.");
    }
}