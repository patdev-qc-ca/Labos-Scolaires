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
            for(int a=0; a<gen.GetDesignationType(); a++)
            {
                for (int b = 0; b < 10; b++) {
                    ListeID.Items.Add($"{gen.GetDesignationType(a)}00{Math.Floor(Math.Pow(Math.PI, b))}");
                }
            }
        }

    }
}
