using System.ComponentModel.DataAnnotations;

namespace Exercice_ProgWeb31.Models
{
    internal class Utilisateurs
    {
        private string adresseMail;
        private string nom;
        private string? prenom;
        private int userID;

        public Utilisateurs(string adresseMail, string nom, string? prenom, int userID)
        {
            this.adresseMail = adresseMail;
            this.nom = nom;
            this.prenom = prenom;
            this.userID = userID;
        }

        public Utilisateurs()
        {
            this.userID = 1;
            this.nom = Environment.UserName;
            this.adresseMail = Environment.UserName + "@" + Environment.UserDomainName + ".intra";
        }

        [Key, Required]
        public int UserID { get => userID; set => userID = value; }
        [Required, StringLength(50)]
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string AdresseMail { get => adresseMail; set => adresseMail = value; }
    }
}