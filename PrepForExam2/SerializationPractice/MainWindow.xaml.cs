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

namespace SerializationPractice
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
            cboGame.Items.Add("All");
            var allGames = File.ReadAllLines("all_games (2).csv").Skip(1);

            foreach (var vidGame in allGames)
            {
                //name,platform,release_date,summary,meta_score,user_review
                string[] currentGame = vidGame.Split(',');
                Game g = new Game();
                g.Name = currentGame[0];
                g.Platform = currentGame[1];
                g.ReleaseDate = currentGame[2];
                g.Summary = currentGame[3];
                g.MetaScore = Convert.ToInt32(currentGame[4]);
                g.UserReview = currentGame[5];

                cboGame.Items.Add("All");
                games.Add(g);
                if (!cboGame.Items.Contains(g.Platform))
                {
                    cboGame.Items.Add(g.Platform);
                }

                lstGames.Items.Add(g);

            }

        }

        private void cboGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstGames.Items.Clear();
            if (cboGame.SelectedItem == "All")
            {
                foreach (var game in games)
                {
                    lstGames.Items.Add(game);
                }
            }
            else
            {
                foreach (var game in games)
                {
                    if (game.Platform == cboGame.SelectedItem)
                    {
                        lstGames.Items.Add(game);
                    }
                }
            }
        }
    }
}
