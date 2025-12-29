using System.Collections.Generic;

namespace Laboratoire2.Models
{
    public class Paniers
    {
        public int ID { get; set; }
        public List<Commande> Commande { get; set; }
    }
}
