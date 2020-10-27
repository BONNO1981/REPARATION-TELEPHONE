using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using REPARATION_TELEPHONE.UI;
using System.Windows.Shapes;
using REPARATION_TELEPHONE.Metier;

namespace REPARATION_TELEPHONE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            this.Listreparationphone.ItemsSource = Business.PhoneRepair;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            APropos nouvelleFenetre = new APropos();
            nouvelleFenetre.ShowDialog();
        }

        private void Button_Click_modifier(object sender, RoutedEventArgs e)
        {
            AddReparation toto = new AddReparation();
            toto.ShowDialog();
        }

        private void Button_Click_ajouter(object sender, RoutedEventArgs e)
        {
            AddReparation toto = new AddReparation();
            toto.ShowDialog();
        }

        private void Button_Click_supprimer(object sender, RoutedEventArgs e)
        {
            AddReparation toto = new AddReparation();
            toto.ShowDialog();
        }

        private void Button_Click_quitter(object sender, RoutedEventArgs e)
        {

        }
    }
}
