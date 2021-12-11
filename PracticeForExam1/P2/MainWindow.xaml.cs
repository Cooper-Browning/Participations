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

namespace P2
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

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            lstConsonants.Items.Clear();
            lstVowels.Items.Clear();
            string word = txtWord.Text.ToLower(); ;

            foreach (var character in word)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    lstVowels.Items.Add(character);
                }
                else
                {
                    lstConsonants.Items.Add(character);
                }
                txtWord.Clear();
            }
        }
    }
}
