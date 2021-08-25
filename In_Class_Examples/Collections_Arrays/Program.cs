using System;

namespace Collections_Arrays
{
    //See ppt on collections to see the questions
    //Create two parallel arrays.  The first will hold student id’s and the second will hold their overall GPA.  
    //Ask the user for one of the id’s that they want to see the GPA for and then output it.
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            string[] studentIDs = new string[3]; //make name plural because holding multiple, 3 is the size
            for (int i = 0; i < studentIDs.Length; i++)
            {
                studentIDs[i] = rand.Next(1300000, 1400000).ToString();
            }
            
            double[] studentGPAs = { 3.0, 4.0, 2.7 };
            //Display all the IDs
            //for (int i = 0; i < studentIDs.Length; i++)
            //{
            //    string id = studentIDs[i];
            //    Console.Write($"\t {id}");
            //}
            // var name = 5; //chooses data type for us
            foreach (string id in studentIDs)
            {
                Console.Write($"\t {id}");
            }

            Console.WriteLine("\nWhose GPA do you want to see?");
            string idToLookFor = Console.ReadLine();

            for (int i = 0; i < studentIDs.Length; i++)
            {
                if (studentIDs[i] == idToLookFor)
                {
                    double gpa = studentGPAs[i];
                    Console.WriteLine($"{idToLookFor} has a {studentGPAs[i].ToString("N2")}");
                }
            }

        }
    }
}
