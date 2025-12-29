using System;
using System.Collections.Generic;
using System.Text;

namespace KeiaLab6
{
    internal class Generateur
    {
        int nombreEtapes = 1;
        string procedure;
        string[] designationType = { "TB", "CH","FT","TB" };


        public Generateur(int nombreEtapes, string procedure)
        {
            this.nombreEtapes = nombreEtapes;
            this.procedure = procedure;
        }

        public Generateur()
        {
            this.nombreEtapes = 0;
            this.procedure=null;
        }

        public int GetDesignationType() {return this.designationType.Length;}
        public int GetNombreEtapes() {return this.nombreEtapes;}
        public string GetProcedure() { return this.procedure;}
        public string GetDesignationType(int position) { return this.designationType[1]; }
     }
}
