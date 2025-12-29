namespace polymorphisme_exercices
{
    class Tablette : Produit
    {
        string Dimension;

        public string GetDimension() { return this.Dimension; }
        public void SetDimension(string value) { this.Dimension = value; }

        public Tablette(int id, string nom, string marque, string modele,string dimension):base( id,  nom,  marque,  modele)
        {
            Dimension = dimension;
        }

        public Tablette() : base()
        {
            this.Dimension = "9 x 10";
        }

        public override string GetCode()
        {
            return $"Dimension: {this.Dimension}" ;
        }
    }
}
