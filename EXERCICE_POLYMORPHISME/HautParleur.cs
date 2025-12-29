namespace polymorphisme_exercices
{
    class HautParleur : Produit
    {
        int SonMaximal;
        int QualiteSonnore;
        bool Surround;

        public HautParleur(int id, string nom, string marque, string modele, int sonMaximal, int qualiteSonnore, bool surround) : base(id, nom, marque, modele)
        {
            this.SonMaximal = sonMaximal;
            this.QualiteSonnore = qualiteSonnore;
            this.Surround = surround;
        }
        public HautParleur() : base()
        {
            this.SonMaximal = 0;
            this.QualiteSonnore = 0;
            this.Surround = false;
        }

        public int SonMaximal1 { get => this.SonMaximal; set => this.SonMaximal = value; }
        public int QualiteSonnore1 { get => this.QualiteSonnore; set => this.QualiteSonnore = value; }
        public bool Surround1 { get => this.Surround; set => this.Surround = value; }

        public override string GetCode()
        {
            return $"La puissance de la batgerie est de {this.PuissanceBatterie}";
        }
    }
}
