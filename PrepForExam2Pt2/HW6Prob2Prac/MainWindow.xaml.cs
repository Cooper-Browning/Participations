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

namespace HW6Prob2Prac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<WineAPI> wines = new List<WineAPI>();
        public MainWindow()
        {
            InitializeComponent();

            string url = "http://pcbstuou.w27.wh-2.com/webservices/3033/api/Wine/Reviews";

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                     string json = response.Content.ReadAsStringAsync().Result;
                     wines = JsonConvert.DeserializeObject<List<WineAPI>>(json);
                }
            }

            foreach (var wine in wines)
            {
                lstWines.Items.Add(wine);
                if (!cboCountry.Items.Contains(wine.country))
                {
                    cboCountry.Items.Add(wine.country);
                }
            }
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            lstWines.Items.Clear();
            string selectedCountry = cboCountry.SelectedItem.ToString();
            foreach (var wine in wines)
            {
                if (wine.country == selectedCountry)
                {
                    if (string.IsNullOrWhiteSpace(txtPrice.Text))
                    {
                        lstWines.Items.Add(wine);
                    }
                    else if (wine.price == "null" || Convert.ToDouble(wine.price) <= Convert.ToDouble(txtPrice.Text))
                    {
                        lstWines.Items.Add(wine);
                    }
                }
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(lstWines.Items, Formatting.Indented);
            File.WriteAllText("wines.json", json);
        }

        private void WineInfo(object sender, MouseButtonEventArgs e)
        {
            WineAPI selectedWine = (WineAPI)lstWines.SelectedItem;

            WineInfo info = new WineInfo();
            info.PopulateData(selectedWine);
            info.Show();
        }
    }
}
