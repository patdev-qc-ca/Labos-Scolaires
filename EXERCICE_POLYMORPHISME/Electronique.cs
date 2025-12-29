namespace polymorphisme_exercices
{
    class Electronique : Produit
    {
        int PuissanceBatterie;

        public Electronique() : base()
        {
            this.PuissanceBatterie = 0;
        }

        public Electronique(int id, string nom, string marque, string modele, int puissanceBatterie) : base(id, nom, marque, modele)
        {
            this.PuissanceBatterie = puissanceBatterie;
        }
        // Ajouter les méthodes pertinentes.

        public int GetPuissanceBatterie() { return this.PuissanceBatterie; }
        public void SetPuissanceBatterie(int value) { this.PuissanceBatterie = value; }
        public override string GetCode()
        {
            return $"La puissance de la batgerie est de {this.PuissanceBatterie}";
        }

    }
}
