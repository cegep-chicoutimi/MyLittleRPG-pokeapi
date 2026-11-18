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
        public int X;
        public int Y;
        public int Type;

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
        public int Id;
        public string Name = "";
        public int Level;
        public int Hp;
        public int MaxHp;
        public int Strength;
        public int Defense;
        public int PosX;
        public int PosY;
        public DateTime CreationDate;

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
    }

    public class DTO
    {

    }
}
