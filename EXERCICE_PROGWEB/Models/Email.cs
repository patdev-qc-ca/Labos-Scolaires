using System.ComponentModel.DataAnnotations;

namespace Exercice_ProgWeb31.Models
{
    internal class Email
    {
        private int emetteur;
        private int recepteur;
        private string? objet;
        private string corps= "Exercice_ProgWeb31";

        [Key, Required]
        public int EmailID { get; set; }
        [Required, StringLength(50)]
        public int Emetteur { get => emetteur; set => emetteur = value; }
        [Required]
        public int Recepteur { get => recepteur; set => recepteur = value; }
        [ Required]
        public string Objet { get => objet; set => objet = value; }
        [Required]
        public string Corps { get => corps; set => corps = value; }
    }
}