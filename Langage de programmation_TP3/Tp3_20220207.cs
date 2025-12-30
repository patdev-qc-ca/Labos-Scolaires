using System;

namespace Tp3_20220207
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " TP3 Patrice Waechter-Ebling 07-02-2022";
          AfficherMenuEtLireTexteInitial();
        }
        static void AfficherCaractParCaractEtRemplacerEspacePar_(string texte) {
            string tmp =  texte;
            for (int a = 0; a < texte.Length; a++)
            {
                if (char.IsWhiteSpace(texte[a]))
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write(tmp[a]);
                }
            }
        }
        static void AfficherTexteAlEnvers(string texte)
        {
            for (int x = 0; x < texte.Length; x++) 
            {
                Console.Write(texte[texte.Length - 1 - x]);
            }
        }
        static void AfficherCaractParCaractEtRemplacerEspaceParChoixUtilisateur(string texte)
        {
            Console.WriteLine("Veuillez choisir un caractère de remplacement svp : ");
            string tmp = Console.ReadLine();
            for (int a = 0; a < texte.Length-1; a++)
            {
                if (char.IsWhiteSpace(texte[a]))
                {
                    Console.Write(tmp);
                }
                else
                {
                    Console.Write(texte[a]);
                }
            }
        }
        static void AnalyserTexte(string texte)
            {
            int[] alpha = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string tmp = null;
            int digit = 0;
            int autre = 0;
            int b = texte.Length;
            Console.WriteLine($"Début de la procédure avec {tmp}");
            for (int x = 0; x < b; x++)
            {
                if (char.IsLetter(texte[x]))
                {
                    for (int z = 97; z < 123; z++)
                    {
                        if (texte[x] == z)
                        {
                            int y = 0;
                            for (int a = 0; a < b; a++)
                            {
                                if (char.IsWhiteSpace(texte[x]))
                                {
                                    Console.WriteLine($"Espace détecté offset: {x}");
                                }
                                if (texte.Substring(a, 1).Contains((char)z)) { y++; alpha[z - 97] = y; }
                            }
                            tmp = tmp + (char)(z);
                        }
                    }
                }
                else if (char.IsDigit(texte[x]))
                {
                    digit++;
                    tmp = tmp + (char)texte[x];
                }
                else
                {
                    autre++;
                    tmp = tmp + texte[x];
                }
            }
            for(int x=0; x<26; x++)
            {
                Console.WriteLine($"Nombre occurences de {(char)(x+97)} ou {(char)(x + 65) } dans le texte = {alpha[x] }.");
            }
            Console.WriteLine($"Nombre total de caractères numériques dans le texte = {digit}.");
            Console.WriteLine($"Nombre total d'occurences de caractères de ponctuations parmi .,;!?  =  {autre}.");
            Console.WriteLine(texte);
        }
        static void AfficherMenuEtLireTexteInitial() 
        {
            Console.WriteLine("Veuillez entrer un mot ou un texte de votre choix puis appuyer sur ENTRÉE : ");
            string abc = Console.ReadLine();
            Console.WriteLine("Selectionner la méthode que vous desirez appliquer [1-4]\n==========================================================\n");
            Console.WriteLine("1. Utiliser la méthode AfficherCaractParCaractEtRemplacerEspacePar_()");
            Console.WriteLine("2. Utiliser la méthode AfficherTexteAlEnvers()");
            Console.WriteLine("3. Utiliser la méthode AfficherCaractParCaractEtRemplacerEspaceParChoixUtilisateur()");
            Console.WriteLine("4. Utiliser la méthode AnalyserTexte()");
            int choix = Convert.ToInt32(Console.ReadLine());
            if (choix >0 && choix < 5)
            {
                if (choix == 1)
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine("[Début méthode AfficherCaractParCaractEtRemplacerEspacePar_()]");
                    AfficherCaractParCaractEtRemplacerEspacePar_(abc);
                    Console.WriteLine("\n[Fin méthode AfficherCaractParCaractEtRemplacerEspacePar_()]");
                }
                if (choix == 2)
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine("[Début méthode AfficherTexteAlEnvers()]");
                    AfficherTexteAlEnvers(abc);
                    Console.WriteLine("\n[Fin méthode AfficherTexteAlEnvers()]");
                }
                if (choix == 3)
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine("[Début méthode AfficherCaractParCaractEtRemplacerEspaceParChoixUtilisateur()]");
                    AfficherCaractParCaractEtRemplacerEspaceParChoixUtilisateur(abc);
                    Console.WriteLine("\n[Fin méthode AfficherCaractParCaractEtRemplacerEspaceParChoixUtilisateur()]");
                }
                if (choix == 4)
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine("[Début méthode AnalyserTexte()]");
                    AnalyserTexte(abc);
                    Console.WriteLine("\n[Fin méthode AnalyserTexte()]");
                }
            }
            else
            {
                Console.WriteLine(" Entree non valide choisissez entre 1 et 4");
            }
            Console.WriteLine("-->> Appuyez sur ENTRÉE pour quitter ou sur n'importe quelle autre touche pour faire un autre tour. <<--");
            if(Console.ReadKey().Key!= ConsoleKey.Enter) 
            {
                Console.Clear();
                AfficherMenuEtLireTexteInitial();
            }
            else 
            {
                return;
            }
        }
    }
}
