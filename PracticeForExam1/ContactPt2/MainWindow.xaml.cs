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

namespace ContactPt2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] AllContacts = File.ReadAllLines("contacts (3).txt");

            for (int i = 1; i < AllContacts.Length; i++)
            {
                string currentContact = AllContacts[i];
                /*
                Contact c = new Contact(currentContact);
                lstContacts.Items.Add(c);
                */
                string[] pieces = currentContact.Split('|');
                Contact c = new Contact();
                c.ID = Convert.ToInt32(pieces[0]);
                c.FirstName = pieces[1];
                c.LastName = pieces[2];
                c.Email = pieces[3];
                c.Photo = pieces[4];

                lstContacts.Items.Add(c);
            }
        }

        private void lstContact_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Contact selected = (Contact)lstContacts.SelectedItem;

            txtFName.Text = selected.FirstName;
            txtLName.Text = selected.LastName;
            txtEmail.Text = selected.Email;

            var uri = new Uri(selected.Photo);
            var img = new BitmapImage(uri);

            imgPhoto.Source = img;

        }
    }
}
