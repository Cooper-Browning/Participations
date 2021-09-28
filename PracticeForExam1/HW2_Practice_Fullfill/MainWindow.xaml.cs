using Microsoft.Win32;
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

namespace HW2_Practice_Fullfill
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, List<FulfillData>> FulfillDatas = new Dictionary<string, List<FulfillData>>();
        public MainWindow()
        {
            InitializeComponent();
        }

        public object OpenFileDialogue { get; private set; }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads"; //This will get the path to their downloads directory,
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = path;
            ofd.Filter = "Comma Separated Value documents(.csv)| *.csv";

            if (ofd.ShowDialog() == true)
            {
                PopulateData(ofd.FileName);

                PopulateListBox("Male", lstMales);
                PopulateListBox("Female", lstFemales);
                PopulateListBox("Both", lstBoth);

                PopulateMeanGreaterThan();

            }



        
        }

        private void PopulateMeanGreaterThan()
        {
            foreach (var state in FulfillDatas.Keys)
            {
                foreach (var dataPiece in FulfillDatas[state])
                {
                    if (dataPiece.Gender.ToLower() == "both".ToLower())
                    {
                        if (dataPiece.Mean >= 8)
                        {
                            lstMean.Items.Add(state);
                        }
                    }
                }
            }
        }

        private void PopulateListBox(string gender, ListBox lstListBox)
        {
            double maxMean = 0;

            foreach (var state in FulfillDatas.Keys)
            {
                foreach (var dataPiece in FulfillDatas[state])
                {
                    if (dataPiece.Gender.ToLower() == gender.ToLower())
                    {
                        if (dataPiece.Mean > maxMean)
                        {
                            maxMean = dataPiece.Mean;
                        }
                    }
                }
            }

            foreach (var state in FulfillDatas.Keys)
            {
                foreach (var dataPiece in FulfillDatas[state])
                {
                    if (dataPiece.Gender.ToLower() == gender.ToLower())
                    {
                        if (dataPiece.Mean == maxMean)
                        {
                            lstListBox.Items.Add(state);
                        }
                    }
                }
            }



        }

        private void PopulateData(string fileName)
        {
            var dataLines = File.ReadAllLines(fileName).Skip(1) ;

            string state = "";
            foreach (var dataLine in dataLines)
            {
                //State,Gender,Mean,N=
                //0    1   2   3
                //AL,Male,7.3,1480
                //0  1     2   3
                //,Female,7.3,1683

                string[] currentLine = dataLine.Split(',');
                if (string.IsNullOrWhiteSpace(currentLine[0]) == false)
                {
                    state = currentLine[0];
                }

                FulfillData fd = new FulfillData();
                fd.State = state;
                fd.Gender = currentLine[1];
                fd.Mean = Convert.ToDouble(currentLine[2]);
                fd.N = currentLine[3];

                if (FulfillDatas.ContainsKey(state) == false)
                {
                    FulfillDatas.Add(state, new List<FulfillData>());
                }
                FulfillDatas[state].Add(fd);

            }

        }
    }
}
