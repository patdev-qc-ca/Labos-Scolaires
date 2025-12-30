using System;

namespace TP5_20220321
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<--- Constructeur Autobus() --->>");
            Autobus UnAutobus = new Autobus();

            Console.WriteLine("\n<-- AfficherAutobus(UnAutobus) -->");
            AfficherAutobus(UnAutobus);

            Console.WriteLine("\n<-- UnAutobus.Ajouter1PassagerAmobiliteReduite() -->");
            UnAutobus.Ajouter1PassagerAmobiliteReduite();

            Console.WriteLine("\n<-- AfficherAutobus(UnAutobus) -->");
            AfficherAutobus(UnAutobus);
            Console.WriteLine("\n<-- UnAutobus.Ajouter1PassagerRegulier() -->");
            UnAutobus.Ajouter1PassagerRegulier();

            Console.WriteLine("\n<-- UnAutobus.Ajouter1PassagerRegulier() -->");
            UnAutobus.Ajouter1PassagerRegulier();

            Console.WriteLine("\n<-- AfficherAutobus(UnAutobus) -->");
            AfficherAutobus(UnAutobus);

            Console.WriteLine("\n<-- UnAutobus.Ajouter1PassagerRegulier() x 12 -->");
            for (int i = 0; i < 12; i++)
            {
                if (!UnAutobus.Ajouter1PassagerRegulier())
                    Console.WriteLine($"{i} - Il n'y a plus de place régulière.");
                else
                    Console.WriteLine($"{i} - OK.");
            }

            Console.WriteLine("\n<-- AfficherAutobus(UnAutobus) -->");
            AfficherAutobus(UnAutobus);

            Console.WriteLine("\n<-- UnAutobus.Retirer1PassagerRegulier() x 5 -->");
            for (int i = 0; i < 5; i++)
            {
                UnAutobus.Retirer1PassagerRegulier();
            }

            Console.WriteLine("\n<-- AfficherAutobus(UnAutobus) -->");
            AfficherAutobus(UnAutobus);

            Console.WriteLine("\n<-- UnAutobus.Ajouter1PassagerRegulier() -->");
            UnAutobus.Ajouter1PassagerRegulier();

            Console.WriteLine("\n<-- AfficherAutobus(UnAutobus) -->");
            AfficherAutobus(UnAutobus);

            Console.WriteLine("\n<-- DeplacerPassagerRegulierVersAvant() -->");
            Console.WriteLine($"Occupation des sieges reguliers {UnAutobus.Occupation[1]}");
            UnAutobus.DeplacerPassagerRegulierVersAvant();

            // UnAutobus.DeplacerPassagerRegulierVersAvantAlternative();

            Console.WriteLine("\n<-- AfficherAutobus(UnAutobus) -->");
            AfficherAutobus(UnAutobus);

            Console.WriteLine("\n");

            Console.WriteLine("<<--- Constructeur Autobus(11) --->>");
            Autobus UnAutreAutobus_11 = new Autobus(11);

            Console.WriteLine("\n<-- AfficherAutobus(UnAutreAutobus_11) -->");
            AfficherAutobus(UnAutreAutobus_11);

            Console.WriteLine("\n");

            Console.WriteLine("<<--- Constructeur Autobus(2) --->>");
            Autobus UnAutreAutobus_2 = new Autobus(2);

            Console.WriteLine("\n<-- AfficherAutobus(UnAutreAutobus_2) -->");
            AfficherAutobus(UnAutreAutobus_2);
        }

        static void AfficherAutobus(Autobus plAutobus)
        {
            for (int i = 0; i < plAutobus.NbrRangees; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{plAutobus.TableauPlaces[i][j]} ");

                Console.WriteLine();
            }
            Console.WriteLine($"Nombre de places régulières disponibles : {plAutobus.NbrPlacesRegDispo}");
            Console.WriteLine($"nombre de places disponibles pour personnes à mobilité réduite : {plAutobus.NbrPlacesMRedDispo}");

        }
    }
}
