using System;

namespace Conditionals_Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //Created instance of this class
            int randomNum = rand.Next(1,101); //Tells rand to give you the next random number between 1 and 100. Use 101 because max is exclusive
            int divisableBy3Remainder = randomNum % 3;
            bool isDivisibleBy3 = divisableBy3Remainder == 0;
          
            if (randomNum % 3 == 0 && randomNum % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }

            else if (randomNum % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else if (randomNum % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else
            {
                Console.WriteLine(randomNum);
            }

        }
    }
}
