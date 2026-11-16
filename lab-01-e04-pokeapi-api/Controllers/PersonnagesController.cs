using lab_01_e04_pokeapi_api.Data.Context;
using lab_01_e04_pokeapi_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

[Route("api/[controller]")]
[ApiController]
public class PersonnagesController : ControllerBase
{
    private readonly PokeContext _context;
    public PersonnagesController(PokeContext context)
    {
        _context = context;
    }

    // GET: api/Personnages
    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<Personnage>>> ListePersonnages()
    {
        string? idUser = HttpContext.Session.GetString("SessionConnexion");
        if(idUser != null)
        {
            return await _context.Personnages.Where(p => p.UtilisateurId.IdUtilisateur == idUser).ToListAsync();
        }
        return Unauthorized();
    }

    // GET: api/Personnages/actual
    [HttpGet("actual")]
    public async Task<ActionResult<Personnage>> AvoirPersonnage()
    {
        string? idUser = HttpContext.Session.GetString("SessionConnexion");
        int? idPersonnage = HttpContext.Session.GetInt32("SessionPersoSelect");
        if (idUser != null && idPersonnage != null)
        {
            Personnage? personnage = await _context.Personnages.Include(p => p.UtilisateurId).FirstOrDefaultAsync(p => p.IdPersonnage == idPersonnage);

            if (personnage != null && personnage.UtilisateurId.IdUtilisateur == idUser)
            {
                //string persoEnJeu = JsonConvert.SerializeObject(personnage);
                //HttpContext.Session.SetString("SessionPersonnageEnJeu", persoEnJeu);
                personnage.UtilisateurId = new Utilisateur();
                return personnage;
            }
        }

        return BadRequest();
    }



    // POST: api/Personnages/select
    [HttpPost("select/{idPersonnage:int}")]
    public async Task<ActionResult<int>> SelectPersonnage(int idPersonnage)
    {
        string? idUser = HttpContext.Session.GetString("SessionConnexion");
        if (idUser != null)
        {
            Personnage? personnage = await _context.Personnages.Include(p => p.UtilisateurId).FirstOrDefaultAsync(p => p.IdPersonnage == idPersonnage); ;

            if (personnage != null && personnage.UtilisateurId.IdUtilisateur == idUser)
            {
                //string persoEnJeu = JsonConvert.SerializeObject(personnage);
                //HttpContext.Session.SetString("SessionPersonnageEnJeu", persoEnJeu);
                HttpContext.Session.SetInt32("SessionPersoSelect", personnage.IdPersonnage);
                Console.WriteLine($"\n\n\n\n\n\n PERSO : {personnage.IdPersonnage}\n\n\n\n\n\n\n\n");
                return 1;
            }
            else 
                return NoContent();
        }
        else
            return Unauthorized();
    }
    // POST: api/Personnages/create
    [HttpPost("create")]
    public async Task<ActionResult<int>> CreatePersonnage([FromForm] string name)
    {
        string? idUser = HttpContext.Session.GetString("SessionConnexion");
        if (idUser != null)
        {
            Utilisateur? user = await _context.Utilisateurs.FindAsync(idUser);
            if(user != null)
            {
                Personnage personnage = new Personnage(name, user);
                await _context.Personnages.AddAsync(personnage);
                await _context.SaveChangesAsync();

                HttpContext.Session.SetInt32("SessionPersoSelect", personnage.IdPersonnage);
            }
            return 1;
        }
        return Unauthorized();
    }

    private bool PersonnageExists(int? idpersonnage)
    {
        return _context.Personnages.Any(e => e.IdPersonnage == idpersonnage);
    }
}
