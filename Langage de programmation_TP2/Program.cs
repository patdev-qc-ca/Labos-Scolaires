using System;

namespace TP2
{
    class Program
    {
        static void Main()
        {
            string ChaineCaracteres = "je prefere programmer en cpp";
            int NombreCaracteres_1 = 15;
            int NombreCaracteres_2 = 55;


            /** Méthode AnalyserSommairementChaineCaracteres
             *  Prend 1 argument (la chaîne de caractères) et ne retourne rien.
             *  Et :
             *  + Affiche le contenu de la chaîne de caractères
             *  + Affiche sa longueur
             *  + Indique que c'est un mot si elle ne contient pas d'espace sinon que c'est une phrase
             *  **/

            Console.WriteLine("Méthode AnalyserSommairementChaineCaracteres()");
            Console.WriteLine("-----------------------------------------------");
            AnalyserSommairementChaineCaracteres(ChaineCaracteres);
            AnalyserSommairementChaineCaracteres("Programmation");

            Console.WriteLine("\n\n_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(\n\n");

            /** Méthode TronquerChaineDeCaracteres
             *  Prend 2 argument (la chaîne de caractères et un nombre entier) et ne retourne rien.
             *  Et :
             *  + Affiche toute la chaîne de caractères si l'entier est égale ou supérieur à sa longueur
             *    sinon uniquement les caractères de la longueur égale à cet entier
             *  + Indique avec l'affichage et entre [] si la chaîne est complète ([COMPLÈTE]) ou partielle ([PARTIELLE])
             *  **/

            Console.WriteLine("Méthode TronquerChaineDeCaracteres()");
            Console.WriteLine("-------------------------------------");
            TronquerChaineDeCaracteres(ChaineCaracteres, NombreCaracteres_1);
            TronquerChaineDeCaracteres(ChaineCaracteres, NombreCaracteres_2);

            Console.WriteLine("\n\n_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(\n\n");

            /** Méthode StructurerEnPhraseExclamative 
             *  Prend 1 argument (la chaîne de caractères) et retourne sa version modifiée.
             *  Et :
             *  + Remplace la première lettre de la chaîne de caractères par une majuscule en 
             *    utilisant la méthode de string appropriée et ajoute un point d’exclamation à la fin.
             *  **/

            Console.WriteLine("Méthode StructurerEnPhraseExclamative()");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(StructurerEnPhraseExclamative(ChaineCaracteres));

            Console.WriteLine("\n\n_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(_.~\"(\n\n");

            /** Méthode AnalyserContenuAlphabetique
             *  Prend 1 argument (la chaîne de caractères) et ne retourne rien.
             *  Et :
             *  + Indique "OUI*" pour chaque lettre de l'alphabet en minuscule si elle est présente dans 
             *    la chaîne de caractères et "non" sinon. 
             *  **/

            Console.WriteLine("Méthode AnalyserContenuAlphabetique()");
            Console.WriteLine("--------------------------------------");
            AnalyserContenuAlphabetique(ChaineCaracteres);

            Console.WriteLine("\n----------------- FIN DU PROGRAMME ----------------------\n");

        }
        static void AnalyserSommairementChaineCaracteres(string ChaineCaracteres)
        {
            bool cpp = ChaineCaracteres.Contains(" ");
            if (cpp == true)
            {
                Console.WriteLine($"\"{ChaineCaracteres}\" est une phrase contenant {ChaineCaracteres.Length} caracteres");
            }
            else
            {
                Console.WriteLine($"\"{ChaineCaracteres}\" est un mot contenant {ChaineCaracteres.Length} caracteres");
            }

        }

        static void TronquerChaineDeCaracteres(string ChaineCaracteres, int NombreCaracteres_1)
        {
            if (NombreCaracteres_1 < ChaineCaracteres.Length)
            {
                Console.WriteLine($"[PARTIELLE] {ChaineCaracteres.Substring(0, NombreCaracteres_1)}");
            }
            else
            {
                Console.WriteLine($"[COMPLÈTE] {ChaineCaracteres}");
            }
        }

        static string StructurerEnPhraseExclamative(string ChaineCaracteres)
        {
            string cpp = ChaineCaracteres.Substring(0, 1).ToUpper() + ChaineCaracteres.Substring(1, ChaineCaracteres.Length - 1).ToLower() + "!";
            return cpp;
        }
        static string LaLettreEstInclue(string ChaineCaracteres, string lettre, ref int nb) //lune satelite de la terre
        {
            string cpp = ChaineCaracteres.ToLower();
            if (cpp.Contains(lettre) == true)
            {                                                                               //  |
                nb++;                                                                       //echange infos
                return "OUI*";                                                              //  |
            }
            else
            {
                return "non";
            }
        }
        static void AnalyserContenuAlphabetique(string ChaineCaracteres) // planete terre
        {
            int nombre = 0;
            Console.WriteLine($"a:{LaLettreEstInclue(ChaineCaracteres, "a", ref nombre)}");
            Console.WriteLine($"b:{LaLettreEstInclue(ChaineCaracteres, "b", ref nombre)}");
            Console.WriteLine($"c:{LaLettreEstInclue(ChaineCaracteres, "c", ref nombre)}");
            Console.WriteLine($"d:{LaLettreEstInclue(ChaineCaracteres, "d", ref nombre)}");
            Console.WriteLine($"e:{LaLettreEstInclue(ChaineCaracteres, "e", ref nombre)}");
            Console.WriteLine($"f:{LaLettreEstInclue(ChaineCaracteres, "f", ref nombre)}");
            Console.WriteLine($"g:{LaLettreEstInclue(ChaineCaracteres, "g", ref nombre)}");
            Console.WriteLine($"h:{LaLettreEstInclue(ChaineCaracteres, "h", ref nombre)}");
            Console.WriteLine($"i:{LaLettreEstInclue(ChaineCaracteres, "i", ref nombre)}");
            Console.WriteLine($"j:{LaLettreEstInclue(ChaineCaracteres, "j", ref nombre)}");
            Console.WriteLine($"k:{LaLettreEstInclue(ChaineCaracteres, "k", ref nombre)}");
            Console.WriteLine($"l:{LaLettreEstInclue(ChaineCaracteres, "l", ref nombre)}");
            Console.WriteLine($"m:{LaLettreEstInclue(ChaineCaracteres, "m", ref nombre)}");
            Console.WriteLine($"n:{LaLettreEstInclue(ChaineCaracteres, "n", ref nombre)}");
            Console.WriteLine($"o:{LaLettreEstInclue(ChaineCaracteres, "o", ref nombre)}");
            Console.WriteLine($"p:{LaLettreEstInclue(ChaineCaracteres, "p", ref nombre)}");
            Console.WriteLine($"q:{LaLettreEstInclue(ChaineCaracteres, "q", ref nombre)}");
            Console.WriteLine($"r:{LaLettreEstInclue(ChaineCaracteres, "r", ref nombre)}");
            Console.WriteLine($"s:{LaLettreEstInclue(ChaineCaracteres, "s", ref nombre)}");
            Console.WriteLine($"t:{LaLettreEstInclue(ChaineCaracteres, "t", ref nombre)}");
            Console.WriteLine($"u:{LaLettreEstInclue(ChaineCaracteres, "u", ref nombre)}");
            Console.WriteLine($"v:{LaLettreEstInclue(ChaineCaracteres, "v", ref nombre)}");
            Console.WriteLine($"w:{LaLettreEstInclue(ChaineCaracteres, "w", ref nombre)}");
            Console.WriteLine($"x:{LaLettreEstInclue(ChaineCaracteres, "x", ref nombre)}");
            Console.WriteLine($"y:{LaLettreEstInclue(ChaineCaracteres, "y", ref nombre)}");
            Console.WriteLine($"z:{LaLettreEstInclue(ChaineCaracteres, "z", ref nombre)}");
            Console.WriteLine($"-->Bilan:{nombre} lettres de l'alphabet en minuscules");
        }
    }
}
