namespace Laboratoire2.Models
{
    public class LigneInventaire
    {
        public int Id { get; set; }
        public Vetement Vetement { get; set; }
        public LigneCommande LigneCommande { get; set; }
        public Inventaire Inventaire{ get; set; }
    }
}
