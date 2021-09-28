using System;
using System.Collections.Generic;
using System.IO;
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

namespace P3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts = new List<Contact>();
        public MainWindow()
        {
            InitializeComponent();

            //Id|FirstName|LastName|Email|Photo


            string[] allContacts = File.ReadAllLines("Contacts.txt");

            for (int i = 1; i < allContacts.Length; i++)
            {
                string current = allContacts[i];


                //0     1       2           3                           4      
                //1|Kerwinn|Moriarty|kmoriarty0@state.gov|https://kelicommheadshots.com/wp-content/uploads/2019/02/Jen-for-Social-Media-2-256x256.jpg

                Contact addingContact = new Contact(current);
                lstContacts.Items.Add(addingContact);

            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact)lstContacts.SelectedItem;

            txtFName.Text = selected.FirstName;
            txtLName.Text = selected.LastName;
            txtEmail.Text = selected.Email;

            var uri = new Uri(selected.Photo);
            var img = new BitmapImage(uri);

            imgContact.Source = img;

        }
    }
}
