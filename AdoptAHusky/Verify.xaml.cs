using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AdoptAHusky
{
    
    /// <summary>
    /// Interaction logic for Verify.xaml
    /// </summary>
    public partial class Verify : Window
    {
        public String dogName { get; set; }
        public String dogBreed { get; set; }
        public String dogShots { get; set; }
        public String dogWeight { get; set; }
        public String dogBday { get; set; }
        public String dogMoF { get; set; }
        public String dogMonthsIn{ get; set; }
        public Verify()
        {
            InitializeComponent();
            
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Congratulations!!!" + "\n" + "You have adoppted this dog!!", "Adoption Confomation");
            this.Close();
        }


        private void Window_Activated(object sender, EventArgs e)
        {
            txtName.Text = dogName;
            txtBreed.Text = dogBreed;
            txtShots.Text = dogShots;
            txtWeight.Text = dogWeight;
            txtBday.Text = dogBday;
            txtMorF.Text = dogMoF;
            txttimeinKenn.Text = dogMonthsIn;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
