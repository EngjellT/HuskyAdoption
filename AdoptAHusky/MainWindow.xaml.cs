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

namespace AdoptAHusky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            

            
        }
       

        private void main_ContentRendered(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdopt_Click(object sender, RoutedEventArgs e)
        {
            Verify verification = new Verify();
            verification.dogName = txtName.Text;
            verification.dogBreed = txtBreed.Text;
            verification.dogShots = txtShots.Text;
            verification.dogWeight = txtWeight.Text;
            verification.dogBday = txtBday.Text;
            verification.dogMoF = txtMoF.Text;
            verification.dogMonthsIn = txtMonthsIn.Text;
            verification.ShowDialog();
            
        }

        private void cbbDogs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (cbbDogs.SelectedIndex == 0)
            {
                lblturbo.Visibility = Visibility.Visible;
                lblMia.Visibility = Visibility.Hidden;
                lblWinter.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Hidden;
                lblApollo.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Turbo";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "43 pounds";
                txtBday.Text = "05-03-2020";
                txtMoF.Text = "Male";
                txtMonthsIn.Text = "1 Month";
            }
            if (cbbDogs.SelectedIndex == 1)
            {
                lblMia.Visibility = Visibility.Visible;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Hidden;
                lblApollo.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Mia";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "18 pounds";
                txtBday.Text = "08-23-2021";
                txtMoF.Text = "Female";
                txtMonthsIn.Text = "2 weeks";
            }
            if (cbbDogs.SelectedIndex == 2)
            {
                lblWinter.Visibility = Visibility.Visible;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Hidden;
                lblApollo.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Winter";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "19 pounds";
                txtBday.Text = "09-19-2021";
                txtMoF.Text = "Female";
                txtMonthsIn.Text = "1 weeks";
            }
            if (cbbDogs.SelectedIndex == 3)
            {
                lblMax.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Visible;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblApollo.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Sky";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "19 pounds";
                txtBday.Text = "10-03-2021";
                txtMoF.Text = "Female";
                txtMonthsIn.Text = "2 weeks";
            }
            if (cbbDogs.SelectedIndex == 4)
            {
                lblApollo.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Visible;
                lblSky.Visibility = Visibility.Hidden;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Max";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "56 pounds";
                txtBday.Text = "06-26-2020";
                txtMoF.Text = "Male";
                txtMonthsIn.Text = "1 month";
            }
            if (cbbDogs.SelectedIndex == 5)
            {
                lblApollo.Visibility = Visibility.Visible;
                lblMax.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Apollo";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "59 pounds";
                txtBday.Text = "04-13-2020";
                txtMoF.Text = "Male";
                txtMonthsIn.Text = "2 month";
            }
            if (cbbDogs.SelectedIndex == 6)
            {
                lblAthena.Visibility = Visibility.Visible;
                lblApollo.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Athena";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "26 pounds";
                txtBday.Text = "07-22-2021";
                txtMoF.Text = "Female";
                txtMonthsIn.Text = "1 month";
            }
            if (cbbDogs.SelectedIndex == 7)
            {
                lblZeus.Visibility = Visibility.Visible;
                lblAthena.Visibility = Visibility.Hidden;
                lblApollo.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Zeus";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "59 pounds";
                txtBday.Text = "04-20-2019";
                txtMoF.Text = "Male";
                txtMonthsIn.Text = "3 month";
            }
            if (cbbDogs.SelectedIndex == 8)
            {
                lblInfinity.Visibility = Visibility.Visible;
                lblZeus.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblApollo.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblRa.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Infinity";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "28 pounds";
                txtBday.Text = "10-02-2021";
                txtMoF.Text = "Male";
                txtMonthsIn.Text = "1 month";
            }
            if (cbbDogs.SelectedIndex == 9)
            {
                lblRa.Visibility = Visibility.Visible;
                lblInfinity.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblApollo.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblAce.Visibility = Visibility.Hidden;
                txtName.Text = "Ra";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "55 pounds";
                txtBday.Text = "06-02-2020";
                txtMoF.Text = "Male";
                txtMonthsIn.Text = "3 month";
            }
            if (cbbDogs.SelectedIndex == 10)
            {

                lblAce.Visibility = Visibility.Visible;
                lblRa.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblAthena.Visibility = Visibility.Hidden;
                lblApollo.Visibility = Visibility.Hidden;
                lblMax.Visibility = Visibility.Hidden;
                lblSky.Visibility = Visibility.Hidden;
                lblWinter.Visibility = Visibility.Hidden;
                lblturbo.Visibility = Visibility.Hidden;
                lblMia.Visibility = Visibility.Hidden;
                lblZeus.Visibility = Visibility.Hidden;
                lblInfinity.Visibility = Visibility.Hidden;
                txtName.Text = "Ace";
                txtBreed.Text = "siberian husky";
                txtShots.Text = "Yes";
                txtWeight.Text = "59 pounds";
                txtBday.Text = "01-11-2019";
                txtMoF.Text = "Male";
                txtMonthsIn.Text = "6 month";
            }
           
        }
        
    }
}
