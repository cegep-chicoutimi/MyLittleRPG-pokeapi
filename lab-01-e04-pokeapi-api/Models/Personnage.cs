using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_01_e04_pokeapi_api.Models
{
    public class Personnage
    {
        private int idPersonnage;
        private string nom = "";
        private int niveau;
        private int pointsDeVie;
        private int pointDeVieMax;
        private int force;
        private int defense;
        private int posX;
        private int posY;
        private Utilisateur utilisateurId = new Utilisateur();
        private DateTime dateCreation;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersonnage
        {
            get => idPersonnage;
            set { idPersonnage = value; }
        }

        public string Nom
        {
            get => nom;
            set
            {
                nom = value ?? throw new ArgumentException("Must have a name");
            }
        }

        public int Niveau
        {
            get => niveau;
            set => niveau = value;
        }

        public int PointsDeVie
        {
            get => pointsDeVie;
            set => pointsDeVie = value;
        }

        public int PointDeVieMax
        {
            get => pointDeVieMax;
            set => pointDeVieMax = value;
        }

        public int Force
        {
            get => force;
            set => force = value;
        }

        public int Defense
        {
            get => defense;
            set => defense = value;
        }

        public int PositionX
        {
            get => posX;
            set => posX = value;
        }

        public int PositionY
        {
            get => posY;
            set => posY = value;
        }

        public Utilisateur UtilisateurId
        {
            get => utilisateurId;
            set => utilisateurId = value;
        }

        public DateTime DateCreation
        {
            get => dateCreation;
            set => dateCreation = value;
        }

        public Personnage()
        {
        }

        public Personnage(string _nom, int _niveau, int _pointDeVieMax,
            int _force, int _defense, int _posX, int _posY,
            Utilisateur _utilisateurId)
        {
            Nom = _nom;
            Niveau = _niveau;
            PointDeVieMax = _pointDeVieMax;
            PointsDeVie = _pointDeVieMax;
            Force = _force;
            Defense = _defense;
            PositionX = _posX;
            PositionY = _posY;
            UtilisateurId = _utilisateurId;
            DateCreation = DateTime.UtcNow;
        }

        // From Json
        private Personnage(int _idPersonnage, string _nom, int _niveau,
            int _pointsDeVie, int _pointDeVieMax, int _force, int _defense,
            int _posX, int _posY, Utilisateur _utilisateurId,
            DateTime _dateCreation)
        {
            idPersonnage = _idPersonnage;
            nom = _nom;
            niveau = _niveau;
            pointsDeVie = _pointsDeVie;
            pointDeVieMax = _pointDeVieMax;
            force = _force;
            defense = _defense;
            posX = _posX;
            posY = _posY;
            utilisateurId = _utilisateurId;
            dateCreation = _dateCreation;
        }

        public override string ToString()
            => JsonConvert.SerializeObject(this);
    }
}
