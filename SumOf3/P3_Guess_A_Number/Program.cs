using System;

namespace P3_Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;

            Console.WriteLine("Enter the minimum integer you want for the number range >>");
            string answer = Console.ReadLine();

            while(int.TryParse(answer, out min) == false)
            {
                Console.WriteLine("Sorry, that input was invalid. Try entering the minimum integer again.");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Enter the maximum integer you want for the number range >>");
            answer = Console.ReadLine();

            while (int.TryParse(answer, out max) == false)
            {
                Console.WriteLine("Sorry, that input was invalid. Try entering the maximum integer again.");
                answer = Console.ReadLine();
            }

            Random Rand = new Random();
            int randomNum = Rand.Next(min, max + 1);
            //Console.WriteLine(randomNum); for testing purposes

            int guess;

            Console.WriteLine($"Guess a number between {min} and {max}");
            answer = Console.ReadLine();

            while (int.TryParse(answer, out guess) == false)
            {
                Console.WriteLine("Sorry, that input was invalid. Try guessing and integer again.");
                answer = Console.ReadLine();
            }


            while (guess != randomNum)
            {

                Console.WriteLine($"You guessed wrong! {guess} is not the right number. Try guessing again >>");
                answer = Console.ReadLine();

                while (int.TryParse(answer, out guess) == false)
                {
                    Console.WriteLine("Sorry, that input was invalid. Try guessing and integer again.");
                    answer = Console.ReadLine();
                }
            }

            Console.WriteLine($"You guessed correctly! Congrats!");

            //Console.WriteLine("Enter the maximum integer you want for the number range >>");
        }
    }
}
