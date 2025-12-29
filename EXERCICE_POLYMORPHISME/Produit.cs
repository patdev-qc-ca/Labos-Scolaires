using System;

namespace polymorphisme_exercices
{
    class Produit
    {
        int Id;
        string Nom;
        string Marque;
        string Modele;

        public string GetNom() { return this.Nom; }
        public void SetNom(string value) { this.Nom = value; }
        public string GetMarque() { return this.Marque; }
        public void SetMarque(string value) { this.Marque = value; }
        public string GetModele() { return this.Modele; }
        public void SetModele(string value) { this.Modele = value; }

        public Produit(int id, String nom, String marque, String modele)
        {
            this.Id = id;
            this.Nom = nom;
            this.Marque = marque;
            this.Modele = modele;
        }
        public Produit()
        {
            this.Id = 0;
            this.Nom = "Pas de nom";
            this.Marque = "Pas de marque";
            this.Modele = "Pas de modele";
        }


        // Ajouter les méthodes pertinentes.
        // Notez que la méthode GetCode() devra changer
        // tout dépendant du type de produit.
        public int GetId() { return this.Id; }
        public void SetID(int value) { this.Id = value; }
        public virtual string GetCode()
        {
            return $"Le produit {Id} est défini comme {Nom} {Marque} {Modele}";
        }

    }
}
