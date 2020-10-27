using REPARATION_TELEPHONE.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace REPARATION_TELEPHONE.UI
{
    /// <summary>
    /// Interaction logic for AddReparation.xaml
    /// </summary>
    public partial class AddReparation : Window
    {
        public AddReparation()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void textNom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textPrenom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textMobile_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textModTel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textDateRecue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonEnAttente_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void buttonEnCours_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void buttonFait_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void textEstimation_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DescRepair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //PrintDialog printer = new PrintDialog();
            //if(printer.ShowDialog()== true)
            //{
            //    printer.PrintVisual(FicheInformation, "Impression facture");
            //}
            string nom = this.textNom.Text;
            string prenom = this.textPrenom.Text;
            string ModeleDuTel = this.ModeleDuTel.Text;
            int mobile = int.Parse(this.textMobile.Text);
            string email = this.textEmail.Text;


            DateTime DateRecue = DateTime.Parse(textDateRecue.Text);
            string statut = this.Statut.Text;
            string estimationTemps = this.textEstimation.Text;
            string phoneDetail = this.phoneDetail.Text;//description


            string reparationAeffectuertext = this.reparationAeffectuerText.Text;
            int prixReparations = int.Parse(this.textPrix.Text);
            DateTime editionfact = DateTime.Parse(textDateEdition.Text);


            reparationphone tata = new reparationphone(nom, prenom, ModeleDuTel, mobile, email)
            {
                dateRecue = DateTime.Parse(textDateRecue.Text),
                statut = this.Statut.Text,
                textEstimation = this.textEstimation.Text,
                phoneDetail = this.phoneDetail.Text,

                reparationAeffectuer = this.reparationAeffectuerText.Text,
                prixReparation = int.Parse(this.textPrix.Text),
                editionFact = DateTime.Parse(textDateEdition.Text),

            };

            Business.PhoneRepair.Add(tata);

        }
    }
}
