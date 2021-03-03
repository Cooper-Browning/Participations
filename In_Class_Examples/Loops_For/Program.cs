using System;

namespace Loops_For
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i <= 1000; i++)
            {
                sum += i; 
            }
            Console.WriteLine($"{sum.ToString("n0")}");
            
            // Count all the way up to 100
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i}");

            }

            for (int i = 3; i < 1001; i += 3)
            {
                //if (i % 3 == 0)
                //{
                    Console.WriteLine(i);
                //}
            }

            for (int i = 10; i >= 0 ; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("BLAST OFF!");
                }
                else
                {
                    Console.WriteLine(i);       
                }
            }
        }
    }
}
