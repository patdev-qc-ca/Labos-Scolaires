namespace polymorphisme_exercices
{
    class Reparation : Service
    {
        Produit ProduitRepare;

        public Produit GetProduitRepare() { return ProduitRepare; }
        public  void SetProduitRepare(Produit value) { this.ProduitRepare = value; }

        public Reparation(int id, double tauxBase, double tauxHoraire, double tempsPrevu,Produit produitRepare):base(id, tauxBase,  tauxHoraire,  tempsPrevu)
        {
            ProduitRepare = produitRepare;
        }

        public Reparation() : base()
        {
            this.ProduitRepare = null;
        }
        public override string GetCode()
        {
            return this.ProduitRepare.ToString();
        }
    }
}
