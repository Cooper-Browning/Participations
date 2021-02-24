using System;

namespace Loops_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky number");
            string answer = Console.ReadLine();
            int luckyNbr;

            while (int.TryParse(answer, out luckyNbr) == false)
            {
                Console.WriteLine("Sorry you entered an invalid integer. Please enter another number>>");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Yay you did it!");
        }
    }
}
