using System;

namespace polymorphisme_exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            Service[] services = new Service[5];
            Produit[] produits = new Produit[10];

            string[] codes = new string[services.Length + produits.Length];

            // Création des services
            Consultation consultation = new Consultation();
            Reparation reparation = new Reparation();
            Service service = new Service();
            Nettoyage nettoyage = new Nettoyage();
            Consultation consultation2 = new Consultation();

            services[0] = consultation;
            services[1] = reparation;
            services[2] = service;
            services[3] = nettoyage;
            services[4] = consultation2;

            // Création des produits
            Electronique electronique = new Electronique();
            HautParleur hautParleur = new HautParleur();
            HautParleur hautParleur2 = new HautParleur();
            Imprimante imprimante = new Imprimante();
            Tablette tablette = new Tablette();
            Tablette tablette2 = new Tablette();
            Tablette tablette3 = new Tablette();
            Ordinateur ordinateur = new Ordinateur();
            Ordinateur ordinateur2 = new Ordinateur();
            Produit produit = new Produit();

            produits[0] = electronique;
            produits[1] = hautParleur;
            produits[2] = hautParleur2;
            produits[3] = imprimante;
            produits[4] = tablette;
            produits[5] = tablette2;
            produits[6] = tablette3;
            produits[7] = ordinateur;
            produits[8] = ordinateur2;
            produits[9] = produit;

            // Ajouter les codes de service
            for (int i = 0; i < services.Length; i++)
            {
                codes[i] = services[i].GetCode();
            }

            // Ajouter les codes de produits
            for(int i = services.Length - 1; i < produits.Length + (services.Length - 1); i++)
            {
                codes[i] = produits[i - (services.Length - 1)].GetCode();
            }

            foreach(string c in codes)
            {
                Console.WriteLine(c);
            }
        }
    }
}
