using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JsonSerializationPrac
{
    /// <summary>
    /// Interaction logic for GameInfoWindow.xaml
    /// </summary>
    public partial class GameInfoWindow : Window
    {
        public GameInfoWindow()
        {
            InitializeComponent();

        }

        public void SetData(Game g)
        {
            txtName.Text = g.Name;
            txtPlatform.Text = g.Platform;
            txtRD.Text = g.ReleaseDate;
            txtSumm.Text = g.Summary;
            txtMeta.Text = g.MetaScore;
            txtUR.Text = g.UserReview;

        }
    }
}
