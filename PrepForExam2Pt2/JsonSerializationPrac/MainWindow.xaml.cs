using Newtonsoft.Json;
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

namespace JsonSerializationPrac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> games = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("all_games (3).csv");

            cboPlatform.Items.Add("All");
            foreach (var line in lines)
            {
                string[] currentGame = line.Split(',');

                Game g = new Game();
                g.Name = currentGame[0];
                g.Platform = currentGame[1];
                g.ReleaseDate = currentGame[2];
                g.Summary = currentGame[3];
                g.MetaScore = currentGame[4];
                g.UserReview = currentGame[5];

                games.Add(g);

                
                if (!cboPlatform.Items.Contains(g.Platform))
                {
                    cboPlatform.Items.Add(g.Platform);
                }
            }
        }

        private void cboPlatform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPlatform = cboPlatform.SelectedItem.ToString();
            lstGames.Items.Clear();
            foreach (var game in games)
            {
                if (selectedPlatform == "All")
                {
                    lstGames.Items.Add(game);
                }
                if (game.Platform == selectedPlatform)
                {
                    lstGames.Items.Add(game);
                }
            }
            lblCount.Content = $"Item Count: {lstGames.Items.Count}";
            
        }

        private void ShowGameInfo(object sender, MouseButtonEventArgs e)
        {
            Game selectedGame = (Game)lstGames.SelectedItem;
            /*
            GameInfoWindow gameInfo = new GameInfoWindow();
            gameInfo.txtName.Text = selectedGame.Name;
            gameInfo.txtPlatform.Text = selectedGame.Platform;
            gameInfo.txtRD.Text = selectedGame.ReleaseDate;
            gameInfo.txtSumm.Text = selectedGame.Summary;
            gameInfo.txtMeta.Text = selectedGame.MetaScore;
            gameInfo.txtUR.Text = selectedGame.UserReview;
            */
            GameInfoWindow gameInfo = new GameInfoWindow();
            gameInfo.SetData(selectedGame);
            gameInfo.Show();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(lstGames.Items, Formatting.Indented);
            File.WriteAllText("games.json", json);
        }
    }
}
