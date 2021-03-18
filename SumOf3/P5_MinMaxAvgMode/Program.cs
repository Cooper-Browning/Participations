using System;
using System.Collections.Generic;

namespace P5_MinMaxAvgMode
{

    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            
            string anotherExam;
            do
            {
                Console.WriteLine("Please enter an exam grade>>");
                double answer = Convert.ToDouble(Console.ReadLine());

                grades.Add(answer);

                Console.WriteLine("Do you have another exam grade to enter?");
                anotherExam = Console.ReadLine();


            } while (anotherExam.ToLower() == "y");

            double totalGrade = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                totalGrade += grades[i]; 
            }
            double avgGrade = totalGrade / grades.Count;
            Console.WriteLine(avgGrade);
            
            
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    double stuGrade = grades[i];
            //    Console.WriteLine(stuGrade);
            //}
        }
    }
}
