using System;
using System.Collections.Generic;

namespace P5_MinMaxAvgMode
{

    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            Dictionary<double, int> examGrades = new Dictionary<double, int>();


            string anotherExam;
            do
            {
                Console.WriteLine("Please enter an exam grade>>");
                double answer = Convert.ToDouble(Console.ReadLine());
                grades.Add(answer);

                if (examGrades.ContainsKey(answer) == false) // if it does not already contain the key, in this case the exam grade
                {
                    examGrades.Add(answer, 1); //must enter two values for add, one for key and one for value
                }
                else
                {
                    examGrades[answer] = examGrades[answer] + 1; //get the value associated witht this key and add one to it
                }

                Console.WriteLine("Do you have another exam grade to enter? Yes or no >>");
                anotherExam = Console.ReadLine();


            } while (anotherExam.ToLower()[0] == 'y');

            //foreach (double grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            
            double totalGrade = 0;
            double min = grades[0];
            double max = grades[0];
        
            for (int i = 0; i < grades.Count; i++) // could also have done foreach loop
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

            int maxOccurences = 0;
            foreach (double key in examGrades.Keys)
            {
                double grade = key; //assign it the value of the key
                if (examGrades[grade] > maxOccurences)
                {
                    maxOccurences = examGrades[grade];
                }
            }
            foreach (double key in examGrades.Keys)
            {
                double grade = key; //assign it the value of the key
                if (examGrades[grade] == maxOccurences)
                {
                    Console.WriteLine($"The grade that appears the most times is: {grade.ToString("N2")} x {maxOccurences}");
                }
            }


            double avgGrade = totalGrade / grades.Count;
            Console.WriteLine($"The average grade for your exams is: {avgGrade.ToString("N2")}");
            Console.WriteLine($"The minimum value of your grades is: {min.ToString("N2")}");
            Console.WriteLine($"The maximum value of your grades is: {max.ToString("N2")}");



          
        }
    }
}
