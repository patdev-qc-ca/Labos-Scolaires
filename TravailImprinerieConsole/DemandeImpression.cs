using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailImprinerieConsole
{
    internal class DemandeImpression:Client
    {
        public int NoDemande { get => this.NoDemande; set => this.NoDemande = value; }
        public bool CreditValide { get => this.CreditValide; set => this.CreditValide = value; }
        /// <summary>
        /// constructeur de la demande d'impression 
        /// oublions pas l'heritage
        /// </summary>
        /// <param name="nbClient"></param>
        /// <param name="adresse"></param>
        /// <param name="nom"></param>
        /// <param name="rabais"></param>
        /// <param name="noDemande"></param>
        /// <param name="creditValide"></param>
        public DemandeImpression(int nbClient, string adresse, string nom, int rabais, int noDemande, bool creditValide = false) : base(nbClient, adresse, nom, rabais)
        {
            this.NoDemande = noDemande;
            this.CreditValide = creditValide;
            if (creditValide == false)
            {
                ApplicationException ex = new("Requète non exécutable crédit insuffisant\nContactez client pour renflouer le compte");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            else
            {
                _ = new Client(nbClient, adresse, nom, rabais);
            }
        }
    }
}
