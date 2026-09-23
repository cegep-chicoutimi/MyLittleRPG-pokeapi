using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab_01_e03_pokeapi_api.Models;
using lab_01_e03_pokeapi_api.Data.Context;

[Route("api/[controller]")]
[ApiController]
public class TuileController : ControllerBase
{
    private readonly PokeContext _context;
    public TuileController(PokeContext context)
    {
        _context = context;
    }

    // GET: api/Tuile
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tuile>>> AvoirMap()
    {
        return await _context.Tuiles.ToListAsync();
    }

    // GET: api/Tuile/10/10
    [HttpGet("{x:int}/{y:int}")]
    public async Task<ActionResult<Tuile>> AvoirTuile(int x, int y)
    {
        try
        {
            var tuile = await _context.Tuiles.FindAsync(x, y);

            if (tuile == null)
            {
                tuile = new Tuile(x, y, Tuile.GenererTuile());
                _context.Tuiles.Add(tuile);
                await _context.SaveChangesAsync();
            }

            return tuile;
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
