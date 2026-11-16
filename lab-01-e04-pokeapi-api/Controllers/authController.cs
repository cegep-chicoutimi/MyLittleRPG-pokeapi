using lab_01_e04_pokeapi_api.Data.Context;
using lab_01_e04_pokeapi_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

[Route("api/[controller]")]
[ApiController]
public class authController : ControllerBase
{
    private readonly PokeContext _context;
    public authController(PokeContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public async Task<ActionResult<bool>> Login([FromForm] string login, [FromForm] string password)
    { // https://learn.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-10.0
        //if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
        //{
        //    HttpContext.Session.SetString(SessionKeyName, "The Doctor");
        //    HttpContext.Session.SetInt32(SessionKeyAge, 73);
        //}
        //var name = HttpContext.Session.GetString(SessionKeyName);
        bool valide = false;

        Utilisateur? user = await _context.Utilisateurs.FirstOrDefaultAsync(e => e.Email == login || e.Pseudo == login);
        if (user != null)
        {
            if (BCrypt.Net.BCrypt.Verify(password, user.MotDePasse))
            {
                HttpContext.Session.SetString("SessionConnexion", user.IdUtilisateur);
                valide = true;
            }
        }
        return valide;
    }

    [HttpPost("register")]
    public async Task<ActionResult<bool>> Register([FromForm] string pseudo, [FromForm] string email, [FromForm] string password)
    {
        Utilisateur? user = await _context.Utilisateurs.FirstOrDefaultAsync(e => e.Email == email || e.Pseudo == pseudo);
        if (user == null)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            user = new Utilisateur(email, hash, pseudo);

            if(!_context.Utilisateurs.Any(e => e.IdUtilisateur == user.IdUtilisateur))
            {
                await _context.Utilisateurs.AddAsync(user);
                await _context.SaveChangesAsync();
                HttpContext.Session.SetString("SessionConnexion", user.IdUtilisateur);
                return true;
            }
        }
        return false;
    }

    [HttpGet("isconnected")]
    public async Task<ActionResult<int>> IsConnected()
    {
        string? idUser = HttpContext.Session.GetString("SessionConnexion");
        return idUser != null && await _context.Utilisateurs.AnyAsync(u => u.IdUtilisateur == idUser) ? 1 : 0;
    }

    [HttpPost("disconnect")]
    public async Task<ActionResult<bool>> Disconnect()
    {
        try
        {
            HttpContext.Session.SetString("SessionConnexion", "");
            HttpContext.Session.SetInt32("SessionPersoSelect", 0);
            HttpContext.Session.Clear();
            return true;
        }
        catch
        {
            return false;
        }
    }

    // HttpContext.Session.GetString("CookieConnexion")

    //// GET: api/auth
    //[HttpGet]
    //public async Task<ActionResult<IEnumerable<Utilisateur>>> GetUtilisateur()
    //{
    //    return await _context.Utilisateurs.ToListAsync();
    //}

    //// GET: api/auth/5
    //[HttpGet("{idutilisateur}")]
    //public async Task<ActionResult<Utilisateur>> GetUtilisateur(int idutilisateur)
    //{
    //    var utilisateur = await _context.Utilisateurs.FindAsync(idutilisateur);

    //    if (utilisateur == null)
    //    {
    //        return NotFound();
    //    }

    //    return utilisateur;
    //}

    //// PUT: api/auth/5
    //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    //[HttpPut("{idutilisateur}")]
    //public async Task<IActionResult> PutUtilisateur(int? idutilisateur, Utilisateur utilisateur)
    //{
    //    if (idutilisateur != utilisateur.IdUtilisateur)
    //    {
    //        return BadRequest();
    //    }

    //    _context.Entry(utilisateur).State = EntityState.Modified;

    //    try
    //    {
    //        await _context.SaveChangesAsync();
    //    }
    //    catch (DbUpdateConcurrencyException)
    //    {
    //        if (!UtilisateurExists(idutilisateur))
    //        {
    //            return NotFound();
    //        }
    //        else
    //        {
    //            throw;
    //        }
    //    }

    //    return NoContent();
    //}

    //// POST: api/auth
    //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    //[HttpPost]
    //public async Task<ActionResult<Utilisateur>> PostUtilisateur(Utilisateur utilisateur)
    //{
    //    _context.Utilisateurs.Add(utilisateur);
    //    await _context.SaveChangesAsync();

    //    return CreatedAtAction("GetUtilisateur", new { idutilisateur = utilisateur.IdUtilisateur }, utilisateur);
    //}

    //// DELETE: api/auth/5
    //[HttpDelete("{idutilisateur}")]
    //public async Task<IActionResult> DeleteUtilisateur(int? idutilisateur)
    //{
    //    var utilisateur = await _context.Utilisateurs.FindAsync(idutilisateur);
    //    if (utilisateur == null)
    //    {
    //        return NotFound();
    //    }

    //    _context.Utilisateurs.Remove(utilisateur);
    //    await _context.SaveChangesAsync();

    //    return NoContent();
    //}

    private bool UtilisateurExists(string? idutilisateur)
    {
        return _context.Utilisateurs.Any(e => e.IdUtilisateur == idutilisateur);
    }
}
