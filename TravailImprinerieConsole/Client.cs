using System.IO;

namespace TravailImprinerieConsole
{
    internal class Client: IEquatable<Client>
    {

        public int nbClient { get => nbClient; set => nbClient = value; }
        public string Adresse { get => Adresse; set => Adresse = value; }
        public string Nom { get => Nom; set => Nom = value; }
        public int Rabais { get => this.Rabais; set => this.Rabais = value; }

        public Client(int nbClient, string adresse, string nom, int rabais)
        {
            this.nbClient = nbClient;
            this.Adresse = adresse;
            this.Nom = nom;
            this.Rabais = rabais;
        }

        public Client()
        {
            this.nbClient = 0;
            this.Nom = "Administrateur";
            this.Adresse = "@@";
            this.Rabais = 100;
        }
        /// <summary>
        /// reappropriation de la fonction ToString()
        /// pour lui faire afficher le nom et l'adresse de l'utilisateur de CETTE instance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nom + " " + this.Adresse;
        }
        /// <summary>
        /// override hash implementation complete et non partielle 
        /// code plus safe
        /// </summary>
        /// <returns></returns>
          public override int GetHashCode()
        {
            return this.nbClient;
        }

        public bool Equals(Client? other)
        {
            Client? objAsPart = other;
            if (objAsPart == null) return false;
            return true;
        }
        /// <summary>
        /// un nouveau client n'a pas de rabais de fidelite donc 0%
        /// </summary>
        /// <param name="nbClient"></param>
        /// <param name="adresse"></param>
        /// <param name="nom"></param>
        public void AjouterClient(int nbClient, string adresse, string nom)
        {
            List<Client> nouveau = new List<Client>
            {
                
                new(nbClient, adresse, nom, 0)
            };
        }
    }
}