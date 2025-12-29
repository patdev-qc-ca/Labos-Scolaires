namespace Laboratoire2.Models
{
    public class Clients
    {
        
        public int ID { get; set; }
        public string Nom { get; set; }
        public Commande Commande { get; set; }
    }
}
