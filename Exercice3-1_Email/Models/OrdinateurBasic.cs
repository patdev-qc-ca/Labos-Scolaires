using System.ComponentModel.DataAnnotations;

namespace Exercice31_Email.Models
{
    public class Ordinateur
    {
        [Key, Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public string Processeur { get; set; }
        public string Marque { get; set; }
        public string Generation { get; set; }
        public string CarteMere { get; set; }
        public string Description { get; set; }
    }
}
