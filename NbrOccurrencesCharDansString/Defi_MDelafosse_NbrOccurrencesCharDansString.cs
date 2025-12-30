/************************************************
*
* Patrice Waechter-Ebling 2022
*
***************************************************/

/*Énoncé du devoir/défi: 
reproduire les fonctionnalités et l'affichage de Demo_NbrOccurrencesCharDansString 
avec 1 seule boucle et le moins de variables possible.

Maurice Delafosse.

-----------------------------------------------
Maurice J.A. Delafosse, ing. MScA MBA
Enseignant
Département des techniques de l'Informatique
Bureau A314
450 372-6614, poste 1142
mjadelafosse@cegepgranby.qc.ca 

 Pour le défis, restreignez vous à la liste de caractères suivants:
char[] CaractRecherches = { 'a','b','c','y','e','f' };
*/

using System;

namespace Defi_MDelafosse_NbrOccurrencesCharDansString //j'ai choisi la version dynamique
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] CaractRecherches = { 'a', 'b', 'c', 'y', 'e', 'f' };
            Console.Write("Entrez un mot ou une phrase SVP : ");
            //string MotEntreParUtilisateur = Console.ReadLine();
             Console.WriteLine(CaractRecherches);
           string MotEntreParUtilisateur ="heures de mise à niveau pour mathématiques 4e secondaire";            
            Console.WriteLine("\n----------->\nVersionCompteurTableauInt(char[] CaractRecherches, string MotEntreParUtilisateur)\n");
            VersionCompteurTableauInt(CaractRecherches,MotEntreParUtilisateur);
            Console.WriteLine("\n----------->\nVersionVieilleEcole(char[] CaractRecherches, string MotEntreParUtilisateur)\n");
            VersionVieilleEcole(CaractRecherches,MotEntreParUtilisateur);
        }
        static void VersionCompteurTableauInt(char[] CaractRecherches, string MotEntreParUtilisateur)
        {
            int[] compteur = new int[CaractRecherches.Length];
            Console.WriteLine(MotEntreParUtilisateur);
            for (int x = 0; x < MotEntreParUtilisateur.Length; x++)
            {
                if (MotEntreParUtilisateur[x] == CaractRecherches[0]) { compteur[0]++; }
                if (MotEntreParUtilisateur[x] == CaractRecherches[1]) {compteur[1]++; }
                if (MotEntreParUtilisateur[x] == CaractRecherches[2]) {compteur[2]++; }
                if (MotEntreParUtilisateur[x] == CaractRecherches[3]) {compteur[3]++; }
                if (MotEntreParUtilisateur[x] == CaractRecherches[4]) {compteur[4]++; }
                if (MotEntreParUtilisateur[x] == CaractRecherches[5]) {compteur[5]++; }
                if ((char)(MotEntreParUtilisateur[x] - 32) == CaractRecherches[0]) {compteur[0]++; }
                if ((char)(MotEntreParUtilisateur[x] - 32) == CaractRecherches[1]) {compteur[1]++; }
                if ((char)(MotEntreParUtilisateur[x] - 32) == CaractRecherches[2]) {compteur[2]++; }
                if ((char)(MotEntreParUtilisateur[x] - 32) == CaractRecherches[3]) {compteur[3]++; }
                if ((char)(MotEntreParUtilisateur[x] - 32) == CaractRecherches[4]) {compteur[4]++; }
                if ((char)(MotEntreParUtilisateur[x] - 32) == CaractRecherches[5]) {compteur[5]++; }
            }
            Console.WriteLine($"Caractere recherche {CaractRecherches[0]} touvé {compteur[0]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[1]} touvé {compteur[1]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[2]} touvé {compteur[2]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[3]} touvé {compteur[3]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[4]} touvé {compteur[4]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[5]} touvé {compteur[5]}");
        }
        static void VersionVieilleEcole(char[] CaractRecherches, string MotEntreParUtilisateur)
        {
            int[] compteur = new int[260];
            Console.WriteLine(MotEntreParUtilisateur);
            for (int x = 0; x < MotEntreParUtilisateur.Length; x++)
            {
                if (MotEntreParUtilisateur[x] < compteur.Length)
                {
                    compteur[MotEntreParUtilisateur[x]]++;
                }
                else
                {
                    compteur[260]++;
                }
            }
            Console.WriteLine($"Caractere recherche {CaractRecherches[0]} touvé {compteur[CaractRecherches[0]]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[1]} touvé {compteur[CaractRecherches[1]]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[2]} touvé {compteur[CaractRecherches[2]]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[3]} touvé {compteur[CaractRecherches[3]]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[4]} touvé {compteur[CaractRecherches[4]]}");
            Console.WriteLine($"Caractere recherche {CaractRecherches[5]} touvé {compteur[CaractRecherches[5]]}");
        }

    }
}
