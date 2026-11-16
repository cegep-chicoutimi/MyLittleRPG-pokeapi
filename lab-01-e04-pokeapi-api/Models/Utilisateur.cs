using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_01_e04_pokeapi_api.Models
{
    public class Utilisateur
    {
        private string idUtilisateur;
        private string email = "";
        private string motDePasse = "";
        private string pseudo = "";
        private DateTime dateInscription;

        private List<Personnage> personnages = new List<Personnage>();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdUtilisateur
        {
            get => idUtilisateur;
            set { idUtilisateur = value; }
        }

        public string Email
        {
            get => email;
            set
            {
                email = value ?? throw new ArgumentException("Must have an email");
            }
        }

        public string MotDePasse
        {
            get => motDePasse;
            set
            {
                motDePasse = value ?? throw new ArgumentException("Must have a password");
            }
        }

        public string Pseudo
        {
            get => pseudo;
            set
            {
                pseudo = value ?? throw new ArgumentException("Must have a pseudo");
            }
        }

        public DateTime DateInscription
        {
            get => dateInscription;
            set => dateInscription = value;
        }

        public List<Personnage> Personnages 
        {
            get => personnages;
            set => personnages = value;
        }

        public Utilisateur() { }

        public Utilisateur(string _email, string _motDePasse, string _pseudo)
        {
            IdUtilisateur = Guid.NewGuid().ToString();
            Email = _email;
            MotDePasse = _motDePasse;
            Pseudo = _pseudo;
            DateInscription = DateTime.UtcNow;
        }

        // From Json
        private Utilisateur(string _idUtilisateur, string _email,
            string _motDePasse, string _pseudo, DateTime _dateInscription, List<Personnage> _personnages)
        {
            idUtilisateur = _idUtilisateur;
            email = _email;
            motDePasse = _motDePasse;
            pseudo = _pseudo;
            dateInscription = _dateInscription;
            personnages = _personnages;
        }

        public override string ToString()
            => JsonConvert.SerializeObject(this);
    }
}
