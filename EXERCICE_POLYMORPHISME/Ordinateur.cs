namespace polymorphisme_exercices
{
    class Ordinateur : Produit
    {
        string ModeleProcesseur;

        public Ordinateur(int id, string nom, string marque, string modele, string modeleProcesseur) : base(id, nom, marque, modele)
        {
            this.ModeleProcesseur = modeleProcesseur;
        }

        public Ordinateur() : base()
        {
            this.ModeleProcesseur = "Pas de processeur";
        }

        public string GetModeleProcesseur() { return this.ModeleProcesseur; }
        public void SetModeleProcesseur(string value) { this.ModeleProcesseur = value; }

        public override string GetCode()
        {
            return this.ModeleProcesseur;
        }
    }
}
