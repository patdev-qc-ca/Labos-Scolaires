using System;
using System.Collections.Generic;
using System.Text;

namespace KeiaLab6
{
    /*  \brief Classe elements
     *  gere les proprietes des items 
     */
    class Elements 
    {
        int id; //id= nomgre relatif a la position
        int Quantite;// nombre de pieces requise par assemblage
        string name; // nom de la piece
        string description; //text user-friendly pour decrire la piece 

        public Elements(int id, int quantite, string name, string description)//constructeur 
        {
            //initialisation et assignation 
            this.id = id;
            Quantite = quantite;
            this.name = name;
            this.description = description;
        }

        public int GetId() { return this.id; }//retourne la position
        public int GetQuantite() {return this.Quantite; }//retourne la quantité
        public string GetName() { return this.name; }//retourne le nom
        public string GetDescription() { return this.description; }//retourne la description
    }
}