using Newtonsoft.Json;
using System.Net.Http.Json;
//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace lab_01
{
    class Program
    {
        const int fromId = 1;
        const int toId = 810;
        const int delay = 100;

        public static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            using StreamWriter sw = new StreamWriter("../../../pokemons.json");
            using JsonTextWriter writer = new JsonTextWriter(sw) { Formatting = Formatting.Indented };
            JsonSerializer serializer = new JsonSerializer();
            int i;

            writer.WriteStartArray();

            for (i = fromId ; i < toId ; i++)
            {
                DateTime start = DateTime.Now;

                try
                {
                    PokeTemplate pt = await GetOnePoke(i, client);
                    Pokemon poke = pt.ConvertToPoke();
                    serializer.Serialize(writer, poke);
                    Console.WriteLine($"[OK] ({i} / {toId-1})\n{pt}\n\n===========\n");
                }
                catch (Exception e) 
                {
                    Console.WriteLine($"[ERROR] : {e.Message}");
                }

                TimeSpan elapsed = DateTime.Now - start;
                TimeSpan remaining = TimeSpan.FromMilliseconds(delay) - elapsed;

                if (remaining > TimeSpan.Zero)
                {
                    await Task.Delay(remaining);
                }
            }

            Console.WriteLine($"\n\n END ({i-1} pokemons)");

            writer.WriteEndArray();
        }

        public static async Task<PokeTemplate> GetOnePoke(int id, HttpClient client)
        {
            string result =  await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{id}");

            return JsonConvert.DeserializeObject<PokeTemplate>(result)!;
        }
    }
}

