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

namespace Participation3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Toy> Toybox = new List<Toy>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtManu.Text))
            {
                valid = false;
                MessageBox.Show("Manufacturer input is invalid");
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                valid = false;
                MessageBox.Show("Name input is invalid");
            }

            if (string.IsNullOrWhiteSpace(txtImage.Text))
            {
                valid = false;
                MessageBox.Show("Image input is invalid");
            }

            double price = 0;
            if (double.TryParse(txtPrice.Text, out price) == false)
            {
                valid = false;
                MessageBox.Show("Price input is invalid");
            }

            if (valid == false)
            {
                return;
            }

            Toy t = new Toy();
            t.Manufacturer = txtManu.Text;
            t.Name = txtName.Text;
            t.Price = Convert.ToDouble(txtPrice.Text);
            t.Image = txtImage.Text;

            lstToyBox.Items.Add(t);

        }

        private void lstToyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)lstToyBox.SelectedItem;

            MessageBox.Show($"Aisle{selectedToy.GetAisle()}");
            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);

            imgToy.Source = img;
        }
    }
}
