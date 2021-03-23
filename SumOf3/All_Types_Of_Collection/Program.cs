using System;
using System.Collections.Generic;

namespace All_Types_Of_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number 1
            string[] subject = new string[3];
            string[] number = new string[3];
            for (int i = 0; i < subject.Length; i++)
            {
                Console.WriteLine($"Please enter course subject number {i+1}>>");
                subject[i] = Console.ReadLine();

                Console.WriteLine("Please enter the corresponding course number for this subject>>");
                number[i] = Console.ReadLine();
            }

            for (int i = 0; i < subject.Length; i++)
            {
                string course = subject[i] + number[i];
                Console.WriteLine($"{course}");
            }

            //Number 2
            List<double> grades = new List<double>();

            string answer;
            do
            {
                Console.WriteLine("Please enter a grade:");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                Console.WriteLine("Do you have another grade to enter? Yes or no:");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            double totalGrade = 0;
            foreach (double grade in grades)
            {
                totalGrade += grade;
            }
            double average = totalGrade / grades.Count;
            Console.WriteLine($"You average grade is: {average.ToString("N2")}");

        }
    }
}
