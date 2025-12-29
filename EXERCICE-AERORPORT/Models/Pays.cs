using System.ComponentModel.DataAnnotations;

#pragma warning disable: 8618

namespace Exercice1_Aerorport.Models
{
    public class Pays
    {
        [Required]
        [StringLength(5)]
        public string Id { get; set; }
        [StringLength(25)]
        public string Nom { get; set; }
    }
}