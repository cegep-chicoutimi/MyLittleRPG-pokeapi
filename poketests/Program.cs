using Newtonsoft.Json;

namespace poketests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../../../pokemons.json");

            string line = sr.ReadToEnd();
            List<Monstre> montres = new List<Monstre>();
            montres = JsonConvert.DeserializeObject<IEnumerable<Monstre>>(line) as List<Monstre>;

            foreach (Monstre m in montres)
            {
                Console.WriteLine(m);
            }
        }
    }
}
