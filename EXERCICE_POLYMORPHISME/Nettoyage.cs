namespace polymorphisme_exercices
{
    class Nettoyage : Service
    {
        Produit ProduitNettoye;

        public Nettoyage(int id, double tauxBase, double tauxHoraire, double tempsPrevu, Produit produitNettoye):base(id,  tauxBase,  tauxHoraire,  tempsPrevu)
        {
            ProduitNettoye = produitNettoye;
        }

        public Nettoyage() : base()
        {
            this.ProduitNettoye = null;
        }

        public Produit GetProduitNettoye() { return ProduitNettoye; }
        public void SetProduitNettoye(Produit value) { this.ProduitNettoye = value; }

        public override string GetCode()
        {
            return this.ProduitNettoye.ToString();
        }
    }
}
