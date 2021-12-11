using System;
using System.Collections.Generic;
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

namespace InClassExamples_Classes
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

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student(Convert.ToInt32(txtID.Text), txtFName.Text, txtLName.Text, Convert.ToDouble(txtBursar.Text));
            s.GPA = Convert.ToDouble(txtGPA.Text);
            s.IsOnProbation = chkProbation.IsChecked.Value;

            lstStudents.Items.Add(s);
            txtBursar.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtID.Clear();
            txtGPA.Clear();
           

        }

        private void lstStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selected = (Student)lstStudents.SelectedItem;

            if (selected.IsOnProbation == true)
            {
                MessageBox.Show($"{selected.FirstName}'s bursar balance is: {selected.CheckBalance()}\n{selected.FirstName} is on probation");
            }
            else
            {
                MessageBox.Show($"{selected.FirstName}'s bursar balance is: {selected.CheckBalance()}\n{selected.FirstName} is not probation");
            }
            
        }
    }
}
