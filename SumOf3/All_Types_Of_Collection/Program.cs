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

            // Number 3
            
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>()); // must create the list, MIS3013 is the key // the first way
            courseGrades["MIS3013"].Add(0.75);
            courseGrades["MIS3013"].Add(1);
            courseGrades["MIS3013"].Add(0.80);

             //OR
            List<double> mis3033Grades = new List<double>(); // the second way
            mis3033Grades.Add(.78);
            mis3033Grades.Add(.99);
            mis3033Grades.Add(.95);
            courseGrades.Add("MIS3033", mis3033Grades);

            courseGrades.Add("MIS3130", new List<double>());
            courseGrades["MIS3130"].Add(.80);
            courseGrades["MIS3130"].Add(.95);
            courseGrades["MIS3130"].Add(.70);

            double courseOne = 0;
            double courseTwo = 0;
            double courseThree = 0;
            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grds = courseGrades[courseCode];
                
                foreach (double grade in grds)
                {
                    if (courseCode == "MIS3013")
                    {
                        courseOne += grade;
                    }
                    else if (courseCode == "MIS3033")
                    {
                        courseTwo += grade;
                    }
                    else
                    {
                        courseThree += grade;
                    }
                }
                
            }
            //Console.WriteLine(courseOne);
            //Console.WriteLine(courseTwo);
            //Console.WriteLine(courseThree);

            double avg3013 = courseOne / 3;
            double avg3033 = courseTwo / 3;
            double avg3130 = courseThree / 3;

            Console.WriteLine($"The average for your class MIS3013 is : {avg3013.ToString("P2")}");
            Console.WriteLine($"The average for your class MIS3033 is : {avg3033.ToString("P2")}");
            Console.WriteLine($"The average for your class MIS3130 is : {avg3130.ToString("P2")}");
            
           
        }
    }
}
