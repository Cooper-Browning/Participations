using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MAGIC_NUMBER = 7.777; //local constant variable, cannot change is constant
            double num1, num2, num3, numTotal, finalNum;

            Console.WriteLine("Enter the first number>>");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number>>");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number>>");
            num3 = Convert.ToDouble(Console.ReadLine());

            numTotal = num1 + num2 + num3;
            Console.WriteLine("The sum is " + numTotal.ToString("N3"));

            finalNum = numTotal * MAGIC_NUMBER;
            Console.WriteLine("The final number is " + finalNum.ToString("N3"));
        }
    }
}
