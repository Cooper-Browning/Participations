using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace GOTPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GOTQuoteAPI> quotes = new List<GOTQuoteAPI>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://got-quotes.herokuapp.com/quotes";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                GOTQuoteAPI quote = JsonConvert.DeserializeObject<GOTQuoteAPI>(json);

                tblQuote.Text = quote.quote;
                lblCharacter.Content = quote.character;

                quotes.Add(quote);
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string serializedJson = JsonConvert.SerializeObject(quotes);

            File.WriteAllText("GOTQuotes", serializedJson);
        }
    }
}
