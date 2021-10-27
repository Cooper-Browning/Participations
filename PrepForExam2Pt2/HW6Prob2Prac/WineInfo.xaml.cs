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

namespace HW6Prob2Prac
{
    /// <summary>
    /// Interaction logic for WineInfo.xaml
    /// </summary>
    public partial class WineInfo : Window
    {
        public WineInfo()
        {
            InitializeComponent();
        }

        public void PopulateData(WineAPI w)
        {
            txtCountry.Text = w.country;
            txtPrice.Text = w.price;
            lblTitle.Content = w.title;

        }
    }
}
