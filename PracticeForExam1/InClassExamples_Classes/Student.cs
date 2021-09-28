using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExamples_Classes
{
    public class Student
    {
        public int ID {get; set;} 
        public string FirstName {get; set;} 
        public string LastName {get; set;} 
        public bool IsOnProbation {get; set;} 
        public double GPA { get; set; }

        private double BursarBalance;

        public Student()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 0;
        }


        public Student(int id, string fName, string lName, double bursarBalance)
        {
            ID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = bursarBalance;
        }

        public void MakePayment(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount must be positive;");
                return;
            }
            BursarBalance -= amount;
        }

        public double CheckBalance()
        {
            return $"{BursarBalance.ToString("N2")}";
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}, ({ID})";
        }
    }
}
