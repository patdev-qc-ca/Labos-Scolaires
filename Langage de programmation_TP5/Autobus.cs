namespace TP5_20220321
{
    class Autobus
    {
        public int NbrRangees { get; private set; }
        public int NbrPassagerPresents { private set; get; }
        public int NbrPlaces { get; private set; }
        public int NbrPlacesRegDispo { get; private set; }
        public int NbrPlacesMRedDispo { get; private set; }

        public char[][] TableauPlaces;
        public int[] PlacesPrises = { 0, 0 };
        private int BuildTheBus(int Rangees)
        {
            NbrPlaces = 4 * NbrRangees;
            NbrPlacesMRedDispo = 4 * 2;
            NbrPlacesRegDispo = (Rangees - 2) * 4;
            NbrPassagerPresents = 0;
            TableauPlaces = new char[NbrRangees][];
            for (int i = 0; i < NbrRangees; i++)
            {
                TableauPlaces[i] = new char[4];
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 || i == (NbrRangees % 2 + 1))
                    {
                        TableauPlaces[i][j] = 'm';
                    }
                    else
                    {
                        TableauPlaces[i][j] = 'r';
                    }
                }
            }
            return NbrPlaces;
        }
        public Autobus()
        {
            NbrRangees = 5;
            NbrPlaces = 4 * 5;
            BuildTheBus(NbrRangees);
        }
        public Autobus(int Rangees)
        {
            if (Rangees < 5) NbrRangees = 5; else NbrRangees = Rangees;
            BuildTheBus(NbrRangees);
        }
        public Autobus(Autobus theBus)
        {
            if (theBus.NbrRangees < 5) NbrRangees = 5; else NbrRangees = theBus.NbrRangees;
            BuildTheBus(NbrRangees);
        }
        public bool Ajouter1PassagerAmobiliteReduite()
        {
            if (NbrPassagerPresents < NbrPlaces)
            {
                NbrPassagerPresents++;
                NbrPlacesMRedDispo--;

                bool PlaceMobiles = false;
                for (int i = 0; i < NbrRangees; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (TableauPlaces[i][j] == (char)0x6D)
                        {
                            TableauPlaces[i][j] = (char)0x59;
                            PlacesPrises[0]++;
                            PlaceMobiles = true;
                            return PlaceMobiles;
                        }
                    }
                    if (PlaceMobiles) break;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        public bool Ajouter1PassagerRegulier()
        {
            if (NbrPassagerPresents < NbrPlaces)
            {
                if (NbrPlacesRegDispo == 0)
                {
                    return false;
                }
                bool PlacesReguliers = false;
                for (int i = 0; i < NbrRangees; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (TableauPlaces[i][j] == 'r')
                        {
                            TableauPlaces[i][j] = 'X';
                            PlacesPrises[1]++;
                            NbrPlacesRegDispo--;
                            NbrPassagerPresents++;
                            PlacesReguliers = true;
                            return PlacesReguliers;
                        }
                    }
                    if (PlacesReguliers) break;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Retirer1PassagerRegulier()
        {
            NbrPassagerPresents--;
            PlacesPrises[1]--;
            NbrPlacesRegDispo++;

            bool PlacesReguliers = false;
            for (int i = 0; i < NbrRangees; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (TableauPlaces[i][j] == 'X')
                    {
                        TableauPlaces[i][j] = 'r';
                        PlacesReguliers = true;

                        break;
                    }
                }
                if (PlacesReguliers) break;

            }
            return true;

        }
        public void DeplacerPassagerRegulierVersAvant()
        {
            for (int i = 0; i < NbrRangees; i++) //reinitialse le tableau des usagers normaux
            {
                for (int j = 0; j < 4; j++)
                {
                    if (TableauPlaces[i][j] == 'X') TableauPlaces[i][j] = 'r';
                }
            }
            for (int a = 0; a < PlacesPrises[1]; a++) //redistribue les places de facon ordonnee
            {
                bool PlacesReguliers = false;
                for (int i = 0; i < NbrRangees; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (TableauPlaces[i][j] == 'r')
                        {
                            TableauPlaces[i][j] = 'X';
                            PlacesReguliers = true;
                            break;
                        }
                    }
                    if (PlacesReguliers) break;
                }
            }
        }
        public void DeplacerPassagerRegulierVersAvantAlternative()
        {
            char[][] newTab = TableauPlaces;//reservation adresse memoire tableau temporaire
            for (int a = 0; a < PlacesPrises[1]; a++) //boucle de recurance pour le nombre de passager
            {
                bool PlacesReguliers = false; //c un regulier ou pas
                for (int i = 0; i < NbrRangees; i++)
                {
                    for (int j = 0; j < 4; j++) //allocation des resources
                    {
                        //                       newTab[i] = new char[4];//reservation adresse memoire tableau temporaire
                        if (newTab[i][j] == 'X') newTab[i][j] = 'r';      //reset datas                   
                        /* if (newTab[i][j] == 'r')//update datas
                         {
                             newTab[i][j] = '8'; //commute libre/occupe
                             PlacesReguliers = true;
                             break;
                         }*/
                    }
                    if (PlacesReguliers) break;
                }
            }
            //         TableauPlaces = newTab; //transfer le tableau temporaire a
            //láncien tableau en ecrassant ce dernier
            // libere les adresses du tableau temporaire en memeoire

        }
    }
}
