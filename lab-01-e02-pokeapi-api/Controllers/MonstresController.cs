using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab_01_e02_pokeapi_api.Models;
using lab_01_e02_pokeapi_api.Data.Context;

[Route("api/[controller]")]
[ApiController]
public class MonstresController : ControllerBase
{
    private readonly PokeContext _context;
    public MonstresController(PokeContext context)
    {
        _context = context;
    }

    // GET: api/Monstres
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Monstre>>> GetMonstre()
    {
        return await _context.Monstres.ToListAsync();
    }

    // GET: api/Monstres/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Monstre>> GetMonstre(int id)
    {
        var monstre = await _context.Monstres.FindAsync(id);

        if (monstre == null)
        {
            return NotFound();
        }

        return monstre;
    }

    // PUT: api/Monstres/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutMonstre(int? id, Monstre monstre)
    {
        if (id != monstre.MonstreId)
        {
            return BadRequest();
        }

        _context.Entry(monstre).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MonstreExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Monstres
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Monstre>> PostMonstre(Monstre monstre)
    {
        _context.Monstres.Add(monstre);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetMonstre", new { id = monstre.MonstreId }, monstre);
    }

    // DELETE: api/Monstres/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMonstre(int? id)
    {
        var monstre = await _context.Monstres.FindAsync(id);
        if (monstre == null)
        {
            return NotFound();
        }

        _context.Monstres.Remove(monstre);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool MonstreExists(int? id)
    {
        return _context.Monstres.Any(e => e.MonstreId == id);
    }
}
