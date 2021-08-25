using System;
using System.Collections.Generic;

namespace Collections_Lists
{
    //Using a List, ask the user to enter all of their favorite things.  Once they are done, randomly pick a value from the list and display it.
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();

            string answer;

            do
            {
                Console.WriteLine("What is one of you favorite things?");
                answer = Console.ReadLine();

                favoriteThings.Add(answer);

                Console.WriteLine("Do you have another favorite thing to add?");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y'); //accounts for yup yes yeah etc.

            Random rand = new Random();
            int randomThingIndex = rand.Next(0, favoriteThings.Count);

            Console.WriteLine($"Your random favorite thing is: {favoriteThings[randomThingIndex]}");
        }
    }
}
