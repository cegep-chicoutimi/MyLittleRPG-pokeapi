namespace lab_01_e04_pokeapi_api.Models
{
    public class DeplacementResult
    {
        public bool EstValide { get; set; }
        public int FinalX { get; set; }
        public int FinalY { get; set; }
        public List<Tuile>? Tuiles { get; set; } = new List<Tuile>();
    }
}
