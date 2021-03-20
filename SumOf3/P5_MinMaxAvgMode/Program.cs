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
                double answer = Convert.ToDouble(Console.ReadLine()) / 100;

                grades.Add(answer);

                Console.WriteLine("Do you have another exam grade to enter?");
                anotherExam = Console.ReadLine();


            } while (anotherExam.ToLower() == "y");

            double totalGrade = 0;
            double min = grades[0];
            double max = grades[0];
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < min)
                {
                    min = grades[i];
                }
                if (grades[i] > max)
                {
                    max = grades[i];
                }
                totalGrade += grades[i]; 
            }
            double avgGrade = totalGrade / grades.Count;
            Console.WriteLine($"The average grade for your exams is: {avgGrade.ToString("P2")}");
            Console.WriteLine($"The minimum of your grades is: {min.ToString("P2")}");
            Console.WriteLine($"The maximum of your grades is: {max.ToString("P2")}");

            //int most;
            //double mode;
            //for (int i = 0; i < grades.Count; i++)
            //{

           // }


            //for (int i = 0; i < grades.Count; i++)
            //{
            //    double stuGrade = grades[i];
            //    Console.WriteLine(stuGrade);
            //}
        }
    }
}
