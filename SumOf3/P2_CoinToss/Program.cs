using System;

namespace P2_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NAME = "Cooper Browning";

            Console.WriteLine("Enter \"heads\" or \"tails\" >>");
            string answer = Console.ReadLine().ToLower();
            int userChoice;

            if (answer.Equals("heads"))
            {
                userChoice = 1;
            }
            else
            {
                userChoice = 2;
            }

            Random rand = new Random();
            int randomNum = rand.Next(1,3); //generate a random # between 1 and 2

            if (randomNum == 1)
            {
                Console.WriteLine("The coin landed on heads.");
                if (userChoice == randomNum)
                {
                    Console.WriteLine("\nYou guessed correctly!");
                }
                else
                {
                    Console.WriteLine("\nSorry, you guessed incorrectly :(");
                }
            }
            else
            {
                Console.WriteLine("\nThe coin landed on tails.");
                if (userChoice == randomNum)
                {
                    Console.WriteLine("\nYou guessed correctly!");
                }
                else
                {
                    Console.WriteLine("\nSorry, you guessed incorrectly :(");
                }
            }

            Console.WriteLine($"\nDeveloper name: {NAME}");
            
        }
    }
}
