using Microsoft.AspNetCore.Mvc;
using lab_01_e04_pokeapi_api.Models;
using lab_01_e04_pokeapi_api.Data.Context;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TypeController : ControllerBase
{
    private readonly PokeContext _context;
    public TypeController(PokeContext context)
    {
        _context = context;
    }

    [HttpGet("{typeName}")]
    public async Task<ActionResult<IEnumerable<Monstre>>> GetType(string typeName)
    {
        List<Monstre> monstres;
        monstres = await _context.Monstres.Where(
            m => m.Type1.ToLower() == typeName.ToLower() || 
            (m.Type2 != null && m.Type2.ToLower() == typeName.ToLower())
        ).ToListAsync();

        if (monstres == null)
        {
            return NotFound();
        }

        return monstres;
    }
}
