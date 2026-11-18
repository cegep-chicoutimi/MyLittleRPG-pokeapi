using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab_01_e04_pokeapi_api.Models;
using lab_01_e04_pokeapi_api.Data.Context;

[Route("api/[controller]")]
[ApiController]
public class TuileController : ControllerBase
{
    private readonly PokeContext _context;
    public TuileController(PokeContext context)
    {
        _context = context;
    }

    // GET: api/Tuile/map
    [HttpGet("map")]
    public async Task<ActionResult<IEnumerable<TuileDTO>>> AvoirMap()
    {
        return TuileDTO.ListToDTO(await _context.Tuiles.ToListAsync());
    }

    private static bool DansChampDeVision(int persoX, int persoY, int x, int y)
        => Math.Abs(x - persoX) <= Personnage.VISION && Math.Abs(y - persoY) <= Personnage.VISION;

    // GET: api/Tuile/100/10/10
    [HttpGet("{idPersonnage:int}/{x:int}/{y:int}")]
    public async Task<ActionResult<TuileDTO>> AvoirTuile(int idPersonnage, int x, int y)
    {
        string? idUser = HttpContext.Session.GetString("SessionConnexion");
        if (idUser != null)
        {
            Personnage? personnage = await _context.Personnages.Include(p => p.UtilisateurId).FirstOrDefaultAsync(p => p.IdPersonnage == idPersonnage);

            if (personnage != null && personnage.UtilisateurId.IdUtilisateur == idUser)
            {
                if (DansChampDeVision(personnage.PositionX, personnage.PositionY, x, y))
                {
                    return await RecupTuileContext(x, y);
                }
            }
        }
        return BadRequest();
    }

    [HttpGet("{x:int}/{y:int}")]
    public async Task<ActionResult<TuileDTO>> AvoirTuileHorsConnexion(int x, int y) 
        => await RecupTuileContext(x, y);


    private async Task<ActionResult<TuileDTO>> RecupTuileContext(int x, int y)
    {
        try
        {
            var tuile = await _context.Tuiles.FindAsync(x, y);

            while (tuile == null)
            {
                tuile = new Tuile(x, y, Tuile.GenererTuile());
                try
                {
                    _context.Tuiles.Add(tuile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    tuile = await _context.Tuiles.FindAsync(x, y);
                }
            }
            return tuile.ToDTO();
        }
        catch (ArgumentOutOfRangeException)
        {
            return NotFound();
        }
    }

    // GET: api/Tuile/all
    [HttpGet("all")]
    public async Task<ActionResult<List<TuileJS>>> TuilesPossible()
    {
        return TuileJS.Liste;
    }


    private bool TuileExists(int? x, int? y)
    {
        return _context.Tuiles.Any(t => t.PositionX == x && t.PositionY == y);
    }

    //[HttpGet("{name}")]
    //public async Task<ActionResult<Tuile>> GetTuile(string name)
    //{
    //    var monstre = await _context.Tuiles.FirstOrDefaultAsync(m => m.Nom.ToLower() == name.ToLower());

    //    if (monstre == null)
    //    {
    //        return NotFound();
    //    }

    //    return monstre;
    //}
}