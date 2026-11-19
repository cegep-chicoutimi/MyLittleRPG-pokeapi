namespace lab_01_e04_pokeapi_api.Models
{
    public class TuileDTO
    {
        public TuileDTO(int x, int y, int type)
        {
            X = x;
            Y = y;
            Type = type;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Type { get; set; }

        public static List<TuileDTO> ListToDTO(List<Tuile> tuiles)
        {
            List<TuileDTO> resultat = new List<TuileDTO>();
            tuiles.ForEach(t =>
            {
                resultat.Add(t.ToDTO());
            });
            return resultat;
        }
    }

    public class DeplacementDTO
    {
        public bool IsCorrect { get; set; }
        public int FinalX { get; set; }
        public int FinalY { get; set; }
        public List<TuileDTO>? Tiles { get; set; } = null;
    }

    public class PersonnageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public DateTime CreationDate { get; set; }

        public PersonnageDTO(int idPersonnage, string nom, int niveau, int pointsDeVie, int pointDeVieMax, int force, int defense, 
                             int posX, int posY, DateTime dateCreation)
        {
            Id = idPersonnage;
            Name = nom;
            Level = niveau;
            Hp = pointsDeVie;
            MaxHp = pointDeVieMax;
            Strength = force;
            Defense = defense;
            PosX = posX;
            PosY = posY;
            CreationDate = dateCreation;
        }



        public static List<PersonnageDTO> ListToDTO(List<Personnage> persos)
        {
            List<PersonnageDTO> resultat = new List<PersonnageDTO>();
            persos.ForEach(p =>
            {
                resultat.Add(p.ToDTO());
            });
            return resultat;
        }
    }

    public class DTO
    {

    }
}
