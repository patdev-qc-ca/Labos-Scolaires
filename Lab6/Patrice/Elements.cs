using System;
using System.Collections.Generic;
using System.Text;

namespace KeiaLab6
{
    /// <summary>
    ///  \brief Classe elements
    ///  gere les proprietes des items
    /// </summary>
    class Elements 
    {
    /// <summary>
    /// id= nomgre relatif a la position
    /// nombre de pieces requise par assemblage
    /// nom de la piece
    /// text user-friendly pour decrire la piece 
    /// </summary>    
        int id; 
        int Quantite;
        string name; 
        string description; 

        public Elements(int id, int quantite, string name, string description)//constructeur 
        {
            ///<summary>
            /// //initialisation et assignation 
            ///</summary>
            this.id = id;
            Quantite = quantite;
            this.name = name;
            this.description = description;
        }

        /// <summary>
        /// Controle des acces
        /// </summary>
        /// <returns></returns>
        public int GetId() { return this.id; }//retourne la position
        public int GetQuantite() {return this.Quantite; }//retourne la quantité
        public string GetName() { return this.name; }//retourne le nom
        public string GetDescription() { return this.description; }//retourne la description
    }
}