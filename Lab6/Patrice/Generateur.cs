using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace KeiaLab6
{
    internal class Generateur
    {
        int nombreEtapes = 1;
        string procedure;
        string[] designationType = { "TB", "CH","FT","GG" };
        string[][] etapes = new string[4][];
        List<string> texte = new List<string>();

        public int GetDesignationType() {return this.designationType.Length;}
        public int GetNombreEtapes() {return this.nombreEtapes;}
        public string GetProcedure() { return this.procedure;}
        public string GetDesignationType(int position) { return this.designationType[position]; }
        public string GetInstructionTexte(int position) { return texte[position]; }

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
        public void GenererMessageEtapes() {
            texte.Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit");
            texte.Add("In tincidunt placerat justo non pretium");
            texte.Add("Integer erat lectus, dapibus ut feugiat non, varius vitae dolor");
            texte.Add("Praesent fringilla vel libero a placerat. Vestibulum commodo elementum nibh vel tristique");
            texte.Add("Nam tempor pulvinar ligula, vel venenatis orci");
            texte.Add("Nulla consequat, urna sed pulvinar ultrices, massa odio euismod urna, vel euismod odio elit eget lorem");
            texte.Add("Quisque efficitur ornare orci, ut ornare nibh pulvinar eu");
            texte.Add("Aliquam scelerisque ornare sollicitudin");
            texte.Add("Pellentesque vel tempus nisl, ut fringilla odio");
            texte.Add("Cras quis eleifend lacus. Mauris fringilla quam sit amet viverra semper");
            texte.Add("Suspendisse eleifend nulla in posuere pharetra");
            texte.Add("Nulla libero leo, laoreet ut rhoncus non, porta non tortor");
            texte.Add("Etiam quis mauris eget erat feugiat semper");
            texte.Add("Donec tincidunt efficitur lorem, sed rutrum neque feugiat non");
            texte.Add("Nunc et mi sit amet arcu varius ornare");
            texte.Add("Sed ut ante ac dui viverra consequat nec at urna");
            texte.Add("Quisque risus urna, pharetra quis ante vitae, finibus luctus velit");
            texte.Add("Nullam non metus eros");
            texte.Add("Interdum et malesuada fames ac ante ipsum primis in faucibus. Proin in arcu enim");
            texte.Add("Mauris malesuada elit sed felis blandit lobortis");
            texte.Add("Praesent egestas fringilla arcu, in rhoncus augue cursus vel");
            texte.Add("Maecenas id metus vitae tortor tempor aliquam dictum vel mauris");
            this.nombreEtapes = texte.Count;
         }
        public List<Elements> GenererListeElement()
        {
            GenererMessageEtapes();
            List<Elements> elements = new List<Elements>();
            MessageBox.Show(this.nombreEtapes.ToString());
            for(int a=0; a<CompositionID().Length; a++)
            {
                if (a < this.nombreEtapes) { 
                    elements.Add(new Elements(a + 1, 1, CompositionID()[a], texte[a]));
                }
                else {
                    elements.Add(new Elements(a + 1, 1, CompositionID()[a], texte[a- this.nombreEtapes]));
                }

            }
            return elements;
        }
         public string[] CompositionID()
        {
            string[] lpID = new string[GetDesignationType() * 10];

            for (int a = 0; a < GetDesignationType(); a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    string pid = "00000000" + Math.Floor(Math.Pow(Math.PI, b)) + GetDesignationType(a);
                    lpID[a + b] = pid.Substring(pid.Length - 8, 8);
                }
            }
            return lpID;
        }

    }
}
