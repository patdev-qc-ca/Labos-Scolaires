namespace Laboratoire2.Models
{
    public class LigneCommande
    {
        public int Id { get; set; }
        public Commande Commande { get; set; }
        public int Quantite { get; set; }
        public int Restant { get; set; }
    }

}
