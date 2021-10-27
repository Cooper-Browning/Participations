using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

namespace Hw4VidPrac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            medRandVid.LoadedBehavior = MediaState.Manual;
            btnPlayPause.IsEnabled = false;
        }

        private void btnGetVid_Click(object sender, RoutedEventArgs e)
        {
            string webUrl = "http://pcbstuou.w27.wh-2.com/webservices/3033/api/random/video";
            RandomVideoAPI vid;
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(webUrl).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    vid = JsonConvert.DeserializeObject<RandomVideoAPI>(json);
                    medRandVid.Source = new Uri(vid.url);
                    medRandVid.Pause();
                    btnPlayPause.Content = "Play";
                    btnPlayPause.IsEnabled = true;
                }
            }


        }

        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            string status = btnPlayPause.Content.ToString().ToLower();
            switch (status)
            {
                case "play":
                    medRandVid.Play();
                    btnPlayPause.Content = "Pause";
                    break;
                case "pause":
                    medRandVid.Pause();
                    btnPlayPause.Content = "Play";
                    break;
            }
            /*
            if (btnGetVid.Content == "Play")
            {
                medRandVid.Play();
                btnGetVid.Content = "Pause";
            }
            else if (btnGetVid.Content == "Pause")
            {
                medRandVid.Pause();
                btnGetVid.Content = "Play";
            }
            */
        }
    }
}
