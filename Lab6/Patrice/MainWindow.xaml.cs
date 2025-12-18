using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeiaLab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Generateur gen = new Generateur();
        public MainWindow()
        {
            InitializeComponent();
            AjouterLogo();
            CompositionID();
            gen.GenererListeElement();
        }
        /// <summary>
        /// Cette fonction charge le fichier image du logo directement dans le dossier images
        /// et lè envoie au controle image nommèe Logo
        /// </summary>
        private void AjouterLogo()
        {
            Image im = new Image();
            string fichierImage = Environment.CurrentDirectory+ "\\images\\logo.jpg";
            im.Source = new BitmapImage(new Uri(fichierImage, UriKind.Absolute));
            Logo.Source = im.Source;
        }
        /// <summary>
        /// Genere le ID puis l
        /// </summary>
        private void CompositionID()
        {
            
            for(int a=0; a<gen.CompositionID().Length; a++)
            {
               string pid=gen.CompositionID()[a];
                if (pid != "")
                {
                   ListeID.Items.Add(pid);
                }
            }
            ListeID.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(null, System.ComponentModel.ListSortDirection.Ascending));
        }
        public void GenererModeEmploi(int position)
        {
            Affichage.Text = "Procédure pour :" + ListeID.SelectedValue;
            for (int a=0; a< gen.GetNombreEtapes(); a++)
            {
                Affichage.Text += $"\nÉtape:{a+1}\n{gen.GetInstructionTexte(a)}"; 
            }
        }

        private void ListeID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GenererModeEmploi(ListeID.SelectedIndex);
        }

        private void Reinitialiser_Click(object sender, RoutedEventArgs e)
        {
            ListeID.Text = "Réinitialisation";
            Affichage.Text = null;

        }
    }
}
