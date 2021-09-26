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

namespace Participation1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int YEAR = 2021;
        public MainWindow()
        {
            InitializeComponent();

            lblAge.Content = "";
            lblDogAge.Content = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int bday;
            int dogAge;

            bday = YEAR - Convert.ToInt32(txtAge.Text);
            dogAge = Convert.ToInt32(txtDogAge.Text) * 7;

            lblAge.Content = $"You were born in {bday}";
            lblDogAge.Content = $"Your dog is {dogAge} years old in dog years";


        }
    }
}
