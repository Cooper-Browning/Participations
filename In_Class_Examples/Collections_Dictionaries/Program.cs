using System;
using System.Collections.Generic;

namespace Collections_Dictionaries
{
    class Program
    {
        //Create a dictionary that the key will be the student id and the value will be their GPA.
        //Ask the user if there is another student they want to add, make sure it doesn’t exist then add it. 
        //Ask them for a student id and output their GPA
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>(); //click lightbulb to put the using statement up top

            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 2.7);

            foreach (var studentID in students.Keys) //student.keys gives list of keys. students.Values gives values
            {
                Console.WriteLine($"\t{studentID}");
            }

            Console.WriteLine("\nWhose GPA do you want to see?");
            string idToLookFor = Console.ReadLine();

            if (students.ContainsKey(idToLookFor) == true)
            {
                Console.WriteLine($"{idToLookFor} has a {students[idToLookFor].ToString("N2")}");
            }
            else
            {
                Console.WriteLine($"{idToLookFor} is not a valid student.");
                Environment.Exit(-1);
            }

            

        }
    }
}
