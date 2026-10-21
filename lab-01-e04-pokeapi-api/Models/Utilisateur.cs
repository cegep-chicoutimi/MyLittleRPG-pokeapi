using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_01_e04_pokeapi_api.Models
{
    public class Utilisateur
    {
        private int idUtilisateur;
        private string email = "";
        private string motDePasse = "";
        private string pseudo = "";
        private DateTime dateInscription;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUtilisateur
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

        public Utilisateur() { }

        public Utilisateur(string _email, string _motDePasse, string _pseudo)
        {
            Email = _email;
            MotDePasse = _motDePasse;
            Pseudo = _pseudo;
            DateInscription = DateTime.UtcNow;
        }

        // From Json
        private Utilisateur(int _idUtilisateur, string _email,
            string _motDePasse, string _pseudo, DateTime _dateInscription)
        {
            idUtilisateur = _idUtilisateur;
            email = _email;
            motDePasse = _motDePasse;
            pseudo = _pseudo;
            dateInscription = _dateInscription;
        }

        public override string ToString()
            => JsonConvert.SerializeObject(this);
    }
}
