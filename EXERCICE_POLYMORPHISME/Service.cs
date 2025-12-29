namespace polymorphisme_exercices
{
    class Service
    {
        int Id;
        double TauxBase;
        double TauxHoraire;
        double TempsPrevu;
        // Ajouter les méthodes pertinentes.
        // Notez que la méthode GetCode() devra changer
        // tout dépendant du type de service.
        public Service(int id, double tauxBase, double tauxHoraire, double tempsPrevu)
        {
            this.Id = id;
            this.TauxBase = tauxBase;
            this.TauxHoraire = tauxHoraire;
            this.TempsPrevu = tempsPrevu;
        }

        public Service()
        {
            this.Id = 0;
            this.TauxBase = 0.00;
            this.TauxHoraire = 0.00;
            this.TempsPrevu = 0.00;
        }

        public int GetId() { return this.Id; }
        public void SetID(int value) { this.Id = value; }
        public double GetTauxBase() { return this.TauxBase; }
        public void SetTauxBase(double value) { this.TauxBase = value; }
        public double GetTauxHoraire() { return this.TauxHoraire; }
        public void SetTauxHoraire(double value) { this.TauxHoraire = value; }
        public double GetTempsPrevu() { return this.TempsPrevu; }
        public void SetTempsPrevu(double value) { this.TempsPrevu = value; }

        public virtual string GetCode()
        {
            return "Code de base du Service";
        }

    }
}
