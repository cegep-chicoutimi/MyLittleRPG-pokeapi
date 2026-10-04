using lab_01_e04_pokeapi_api.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IO;

namespace lab_01_e04_pokeapi_api.Data.Context
{
    public class PokeContext : DbContext
    {
        public DbSet<Monstre> Monstres { get; set; }
        public DbSet<Tuile> Tuiles { get; set; }

        public PokeContext(DbContextOptions<PokeContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            try
            {
                StreamReader sr = new StreamReader("../pokemons.json");

                string line = sr.ReadToEnd();
                List<Monstre> monstres;
                monstres = JsonConvert.DeserializeObject<IEnumerable<Monstre>>(line) as List<Monstre> ?? new List<Monstre>();

                foreach(Monstre m in monstres) { m.MonstreId = m.PokemonId; }

                modelBuilder.Entity<Monstre>().HasData(monstres);
                modelBuilder.Entity<Tuile>().HasKey(t => new { t.PositionX, t.PositionY });
            }
            catch
            {
                modelBuilder.Entity<Monstre>().HasData(Monstre.MissingNo());
            }
        }
    }
}
