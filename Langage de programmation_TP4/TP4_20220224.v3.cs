using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Threading;

namespace TP4_20220224.v3
{ 
    internal class Relooking
    {
        static public void InitConsole() {
            Console.SetWindowPosition(0, 0); 
            Console.SetWindowSize(0x96, 0x28); // tenir compte du ratio pixel
            Console.SetBufferSize(0xA8, 0x3C);
            Console.Clear();
            Console.Title = "TP4_20220224.v3  Mise à jour du 02 mars 2022";
            Console.WriteLine(Console.Title);
        }
       static public string Separateur()
        {
            string tmp = " ╠";
            for (int x = 0; x < Tableau.Configuration[1]-1; x++)
                {
                    tmp += "════╬";
                }
            tmp +=  "════╣";
            return tmp;
        }
        static public void Alerte(string Message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Message);
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
        }
        static public string BordureHaute()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string tmp = " ╔";
            for (int i = 0; i < Tableau.Configuration[1] - 1; i++)
            {
                tmp+="════╦";
            }
            tmp+="════╗";
              return tmp;
        }
        static public string BordureBasse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string tmp = " ╚";
            for (int x = 0; x < Tableau.Configuration[1]-1; x++)
            {
                tmp = tmp + "════╩";
            }
            tmp = tmp + "╝";
            return tmp;
        }
        static public void EchangeCouleur(string Corps, string Texte)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Corps);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Texte);
        }
        static public void EchangeCouleur(string Corps, int Valeur)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Corps);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Valeur);
        }    
    }
    internal class Tableau 
    {        
        static public int[] Configuration = { 0, 0 };
        static public int[][] TableauDynamique2D;
        static public bool ProtectionTableauVide() 
        {
            if (TableauDynamique2D[0][0] == 0 && TableauDynamique2D[0][1] == 0) 
            {
                System.Random random = new System.Random();
                for (int i = 0; i < Configuration[0]; i++)
                {
                    for (int j = 0; j < Configuration[1]; j++)
                    {
                        TableauDynamique2D[i][j] = ((int)random.Next(10, 40));
                    }
                }
                return true;

            }
            return false;
        }
        static public void BuildConfigTableauDynamique2D()
        {
            Console.WriteLine(">> DEBUT PROGRAMME - TABLEAU 2D <<");
            Console.Write("Entrez le nombre de lignes voulues svp :");
            Configuration[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez le nombre de colones voulues svp :");
            Configuration[1] = Convert.ToInt32(Console.ReadLine());
            CreeTableauDynamique2D();
        }
        static public void RemplirTableauDynamique2DManuellement()
        {
            Console.WriteLine("> RemplirTableauDynamique2DManuellement()");
            Relooking.Alerte("\n[IMPORTANT] entrez une valeur entre 10 et 40\n");
            for (int i = 0; i < Configuration[0]; i++)
            {
                for (int j = 0; j < Configuration[1]; j++)
                {
                    Console.Write($"Tableau2D[{i}][{j}] =");
                    int b = Int32.Parse(Console.ReadLine());
                    if (b > 9 && b < 41)
                    {
                        TableauDynamique2D[i][j] = b;
                    }
                    else
                    {
                        Relooking.Alerte($" -- {b} ne respecte pas les paramètres --\n");
                        j--;
                    }
                }
            }
            Menu.BackToMenu();
        }
        static public void RemplirTableauDynamique2DAutomatiquement()
        {
            Console.WriteLine("> RemplirTableauDynamique2DAutomatiquement()");
            System.Random random = new System.Random();
            for (int i = 0; i < Configuration[0]; i++)
            {
                for (int j = 0; j < Configuration[1]; j++)
                {
                    TableauDynamique2D[i][j] = ((int)random.Next(10, 40));
                }
            }
            
            Menu.BackToMenu();
        }
        static public void CreeTableauDynamique2D()
        {
            TableauDynamique2D = new int[Configuration[0]][];
            for (int i = 0; i < Configuration[0]; i++)
            {
                TableauDynamique2D[i] = new int[Configuration[1]];
            }
            TableauVide = true;
        }
        static public void AfficherTableauDynamique2DtelQueCree(int[][] TableauDynamique2D)
        {
            Console.WriteLine("\n> AfficherTableauDynamique2DtelQueCree() : ");

            for (int i = 0; i < Configuration[0]; i++)
            {
                for (int j = 0; j < Configuration[1]; j++)
                    Console.Write($"{TableauDynamique2D[i][j]} ");

                Console.WriteLine();
            }
            Console.WriteLine();
            Menu.BackToMenu();
        }
        static public void AfficherTableauDynamique2DAvecSwap()
        {
            Console.WriteLine("\n> AfficherTableauDynamique2DAvecSwap() : ");
            for (int i = 0; i < Tableau.Configuration[1]; i++)
            {
                for (int j = 0; j < Tableau.Configuration[0]; j++)
                    Console.Write($"{TableauDynamique2D[j][i]} ");
                Console.WriteLine();
            }
            Menu.BackToMenu();
        }
        static public void AfficherTableauDynamique2DValeurDoublee()
        {
            Console.WriteLine("\n> AfficherTableauDynamique2DValeurDoublee() : ");
            for (int i = 0; i < TableauDynamique2D.Length; i++)
            {
                for (int j = 0; j < TableauDynamique2D[i].Length; j++)
                    Relooking.EchangeCouleur($"[{i+1}][{j+1}]:" ,$"{TableauDynamique2D[i][j]}x2={TableauDynamique2D[i][j] * 2} ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Menu.BackToMenu();
        }
        static public void AfficherTableauDynamique2DtelQueCreeAvecCadre()
        {
            Console.WriteLine("\n> AfficherTableauDynamique2DtelQueCreeAvecCadre() :");
            Console.WriteLine(Relooking.BordureHaute());
            for (int i = 0; i < Configuration[0]; i++)
            {
                for (int j = 0; j < TableauDynamique2D[i].Length; j++)
                {
                    Relooking.EchangeCouleur(" ║ ", TableauDynamique2D[i][j]);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ║");

                if (i == Configuration[1] )
                {
                    Console.WriteLine(Relooking.BordureBasse());
                }
                else { 
                    Console.WriteLine(Relooking.Separateur());
                }
            }
            Menu.BackToMenu();
        }
        static public bool TableauVide  { get; private set; }
        static public void ProtegeTableau()
        {
            Relooking.Alerte("ProtectionTableau: Détection champs vides.");
            Relooking.EchangeCouleur("\tDomaine d'opération :", "[10,40]\n");
            TableauVide = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
    internal class Menu 
    {
        static public void MenuCouleur(string Texte)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Texte[0]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Texte[1]);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int a = 2; a < Texte.Length; a++)
            {
                Console.Write(Texte[a]);
            }
            Console.Write("\n");

        }
        static public void BackToMenu() {
            Thread.Sleep(3000);
            Console.Clear();
            MenuAction();
        }
        static public void MenuCouleur(string Texte, int interval)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Texte[0]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Texte[1]);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int a = 2; a < Texte.Length; a++)
            {
                Thread.Sleep(100);
                Console.Write(Texte[a]);
            }
            Console.Write("\n");
        }
        static void CadreMenu(string Titre) {
            int a = Titre.Length + 4;
            Console.ForegroundColor = ConsoleColor.Yellow;
            string intercalaire = "+";
            for(int i=0; i<a-2; i++)
            {
                    intercalaire += "═";
            }intercalaire += "╗";
            Console.Write(intercalaire); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write($"\t{MiseAJour_02032022.Aujourdhui()}"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n║ {Titre} ║\tTableau2D {Tableau.Configuration[0]} lignes ayants {Tableau.Configuration[1]} colonnes");
            Console.WriteLine(intercalaire.Replace("╔","╚").Replace("╗","╝"));
            Console.ForegroundColor = ConsoleColor.White;
            if (Tableau.TableauVide == true)
            {
                Console.WriteLine("\nIl est recommandé de procéder au remplissage des donnés");
                Tableau.ProtegeTableau();
                MenuCouleur(MiseAJour_02032022.TexteMenu[0]); // menu genre scroll LCD
                MenuCouleur(MiseAJour_02032022.TexteMenu[1]); // menu genre scroll LCD
                MenuCouleur(MiseAJour_02032022.TexteMenu[MiseAJour_02032022.TexteMenu.Length-1]); // menu genre scroll LCD
            }
            else
            {
                for (int i = 0; i < MiseAJour_02032022.TexteMenu.Length; i++)
                {
                    MenuCouleur(MiseAJour_02032022.TexteMenu[i],5); // menu genre scroll LCD
                }
            }
        }
        static int CreerMenu() 
         {
            Menu.CadreMenu("Choisissez parmi les options suivantes");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\tVotre choix ? ");
          return (int)Console.ReadKey(true).Key; 
         }
        public static void MenuAction()
        {
            int mnu=CreerMenu();
            if (mnu > 96 && mnu < 103 || mnu == 81 || mnu == 113)
            {
                if (mnu == 97) { Tableau.RemplirTableauDynamique2DManuellement(); }
                if (mnu == 98) { Tableau.RemplirTableauDynamique2DAutomatiquement(); }
                if (mnu == 99) { Tableau.AfficherTableauDynamique2DtelQueCree(Tableau.TableauDynamique2D); }
                if (mnu == 100) { Tableau.AfficherTableauDynamique2DAvecSwap(); }
                if (mnu == 101) { Tableau.AfficherTableauDynamique2DValeurDoublee(); }
                if (mnu == 102) { Tableau.AfficherTableauDynamique2DtelQueCreeAvecCadre(); }
                if(mnu ==81 || mnu == 113){Console.WriteLine(">> FIN DU PROGRAMME <<");Environment.Exit(mnu);}
            }
            else 
            { 
                Relooking.Alerte("-- Entrée invalide --");
                Relooking.Alerte($"\t{(char)mnu} ne respecte pas les paramètres ");
                Relooking.Alerte($"\tRedémarrage du sélecteur du au code {mnu}\n");
                MenuAction();
            }
        }
    }
    internal class MiseAJour_02032022
    {
        static public string[] jours = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
        static public string[] mois = { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "décembre" };
        static public string[] TexteMenu =
        {
           "(1) Remplissage manuel"
            ,"(2) Remplissage automatique"
            ,"(3) Affichage tel que créé"
            ,"(4) Affichage Lignes <-> Colonnes"
            ,"(5) Affichage valeurs doublées"
            ,"(6) Affichage tel que créé avec cadre"
            ,"(Q) Quitter le programme"
        };
        static void Main(string[] args)
        {
            Relooking.InitConsole();
            Tableau.BuildConfigTableauDynamique2D();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("En cas d'erreur de saisie appuyez sur 'ESC' pour revenir a la saisie des parametres du tableau sinon presser\nn'importe quelle touche pour confirmer vos choix");
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Tableau.BuildConfigTableauDynamique2D();
                Menu.MenuAction();
            }
            else
            {
                Menu.MenuAction();
            }
        }
        static public string Aujourdhui() 
        {
            return $"Nous sommes {jours[(int)DateTime.Now.DayOfWeek - 1]},le {DateTime.Now.Day} {mois[(int)DateTime.Now.Month - 1]} {DateTime.Now.Year}";

        }
    }
}
