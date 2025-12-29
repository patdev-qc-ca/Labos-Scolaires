using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Exercice1_Aerorport.Models
{
    public class Aeroport {

        [Required]
        public int Id { get; set; }
        [StringLength(25)]
        public string Nom { get; set; }
        [StringLength(5)]
        public string IdPays { get; set; }
    }
}
