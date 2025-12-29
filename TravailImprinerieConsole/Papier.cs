using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TravailImprinerieConsole
{
    internal class Papier:Encre
    {
       public int StockPages { get => this.StockPages; set => this.StockPages = value; }
       public int nbPages { get => this.nbPages; set => this.nbPages = value; }
        public Papier(int nbPages)
        {
            this.nbPages = nbPages;
            this.StockPages -= nbPages;
            this.BourragePapier();
        }
        public bool BourragePapier()
        {
            if (this.StockPages != 0)
            {
                return true;
            }
            else
            {
                InsufficientExecutionStackException ex = new("Remplissez le bac de feuilles ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
