using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace lab_01_e04_pokeapi_api.Models
{

    public class Tuile
    {
        public const int MIN = 1;
        public const int MAX = 50;

        private static List<(int, bool, string, int)> tuilesListe = new List<(int, bool, string, int)>{
            (0, true, "../assets/Forêt.png", 15),
            (1, false, "../assets/Montagne.png", 15),
            (2, true, "../assets/Plaine.png", 20),
            (3, false, "../assets/Rivière.png", 10),
            (4, true, "../assets/Route.png", 35),
            (5, true, "../assets/Ville.png", 5) 
        };

		private int posX;
        private int posY;
        private int tType;
		private bool estTraversable;
		private string url = "";

        public int PositionX
		{
			get { return posX; }
			set 
			{
				if(value < MIN || value > MAX)
				{
					throw new ArgumentOutOfRangeException($"Must be between {MIN} and {MAX}");
				}
				posX = value;
			}
		}

        public int PositionY
		{
			get { return posY; }
			set
            {
                if (value < MIN || value > MAX)
                {
                    throw new ArgumentOutOfRangeException($"Must be between {MIN} and {MAX}");
                }
                posY = value;
			}
		}

		public int Type
		{
			get { return tType; }
			set { tType = value; }
		}

		public string ImageUrl
		{
			get { return url; }
			set { url = value; }
        }

        public bool EstTraversable
        {
            get { return estTraversable; }
            set { estTraversable = value; }
        }

        public static List<(int, bool, string, int)> ToutesTuiles
        {
            get => tuilesListe;
        }

        public static (int, bool, string, int) GenererTuile()
		{
            double roll = Random.Shared.NextDouble() * 100;
            double cumul = 0;

            foreach (var terrain in tuilesListe)
            {
                cumul += terrain.Item4;
                if (roll < cumul)
                {
                    return terrain;
                }
            }

            return tuilesListe.Last();
        }

        public Tuile(int positionX, int positionY, int type, string imageUrl, bool estTraversable)
        {
            PositionX = positionX;
            PositionY = positionY;
            Type = type;
            ImageUrl = imageUrl;
            EstTraversable = estTraversable;
        }

        public Tuile(int positionX, int positionY, (int, bool, string, int) tuileDeListe)
        {
            PositionX = positionX;
            PositionY = positionY;
            Type = tuileDeListe.Item1;
            EstTraversable = tuileDeListe.Item2;
            ImageUrl = tuileDeListe.Item3;
        }

        public Tuile() 
        {
            posX = -1;
            posY = -1;
            Type = -1;
            EstTraversable = false;
            ImageUrl = "";
        }
    }
}