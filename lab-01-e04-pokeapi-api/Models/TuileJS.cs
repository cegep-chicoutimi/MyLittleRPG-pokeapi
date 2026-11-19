namespace lab_01_e04_pokeapi_api.Models
{
    public class TuileJS
    {
        public int Type { get; set; }

        public string Url { get; set; } = string.Empty;

        public bool CanGoThrough { get; set; }

        public string Name { get; set; } = string.Empty;

        public static List<TuileJS> Liste
        {
            get 
            {
                List<TuileJS> list = new List<TuileJS>();
                foreach(var tuile in Tuile.ToutesTuiles)
                {
                    list.Add(new TuileJS(
                        tuile.Item1, tuile.Item2, tuile.Item3, Path.GetFileNameWithoutExtension(tuile.Item3)
                        ));  
                }
                return list;
            }
        }

        public TuileJS() { }

        public TuileJS(int type, bool estTraversable, string url, string nom) 
        { 
            Type = type;
            Url = url;
            CanGoThrough = estTraversable;
            Name = nom;
        }
    }
}
