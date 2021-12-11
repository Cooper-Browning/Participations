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

namespace InClassPracticeFiles
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

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            string fileLocation = txtFile.Text;

            if (File.Exists(fileLocation) == false)
            {
                MessageBox.Show("This file does not exist");
                txtFile.Clear();
                return;
            }

            //Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude

            //1 / 2 / 09 6:17,Product1,1200,Mastercard,carolina,Basildon,England,United Kingdom,1 / 2 / 09 6:00,1 / 2 / 09 6:08,51.5,-1.1166667

            string[] salesDatas = File.ReadAllLines(fileLocation);

            for (int i = 1; i < salesDatas.Length; i++)
            {
                string current = salesDatas[i];

                string[] data = current.Split(',');

                SalesData sd = new SalesData();
                sd.TransactionDate = Convert.ToDateTime(data[0]);
                sd.Product = data[1];
                sd.Price = Convert.ToDouble(data[2].Trim('"'));
                sd.PaymentType = data[3];
                sd.Name = data[4];
                sd.City = data[5];
                sd.State = data[6];
                sd.Country = data[7];
                sd.AccountCreated = Convert.ToDateTime(data[8]);
                sd.LastLogin = Convert.ToDateTime(data[9]);
                sd.Latitude = Convert.ToDouble(data[10]);
                sd.Longitude = Convert.ToDouble(data[11]);


                if (sd.PaymentType == "Mastercard" && sd.Product == "Product1")
                {
                    lstSalesData.Items.Add(sd);
                }

            }
        }
    }
}
