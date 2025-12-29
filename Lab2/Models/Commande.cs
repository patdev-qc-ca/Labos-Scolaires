namespace Laboratoire2.Models
{
    public class Commande
    {
        public int ID { get; set; }
        public DateTime DateCommande { get; set; }
        public Vetement Vetement { get; set; }
        public void ConfirmerCommande() { 
        }
    }
}