using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you lucky # (whole number) >>");
            string answer = Console.ReadLine();
            int luckyNumber;

            bool isAnswerAnInteger = int.TryParse(answer, out luckyNumber);

            if (isAnswerAnInteger == false)
            {
                Console.WriteLine("Sorry that is an invalid number. Goodbye.");
                //return; 
                Environment.Exit(-1);
            }

            int remainder = luckyNumber % 7;

            if (remainder == 0)
            {
                //ctrl + k + d for formatting
                Console.WriteLine($"{luckyNumber.ToString("N0")} is a really lucky number!");
            }
            else if (luckyNumber % 13 == 0)
            {
                Console.WriteLine($"{luckyNumber.ToString("N0")} is a really unlucky number :(");
            }
            else
            {
                Console.WriteLine($"meh...{luckyNumber.ToString("N0")}");
            }

            Console.WriteLine("What is your firstname >>");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "cooper":
                    Console.WriteLine("That's the coolest name ever!");
                    break;
                case "mia":
                    Console.WriteLine("That's a cool name too!");
                    break;
                default:
                    Console.WriteLine("Cool");
                    break;
            }
        }
    }
}
