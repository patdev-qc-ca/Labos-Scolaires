using System.ComponentModel.DataAnnotations;

namespace Exercice1_Aerorport.Models
{
    public class Passager
    {
       [Required]
        public int Id { get; set; }
        [StringLength(15)]
        public string Nom { get; set; }
        [StringLength(15)]
        public string Prenom { get; set; }
        [StringLength(10)]
        public string CodePostal{ get; set; }
        public int Numero { get; set; }
        [StringLength(20)]
        public string Rue { get; set; }
        [StringLength(20)]
        public string Localitee { get; set; }
        [StringLength(14)]
        public string numPassport { get; set; }
        Pays pays;
    }
}
