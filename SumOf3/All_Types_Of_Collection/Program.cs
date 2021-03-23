using System;

namespace All_Types_Of_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subject = new string[3];
            string[] number = new string[3];
            for (int i = 0; i < subject.Length; i++)
            {
                Console.WriteLine($"Please enter course subject number {i+1}>>");
                subject[i] = Console.ReadLine();

                Console.WriteLine("Please enter the corresponding course number for this subject>>");
                number[i] = Console.ReadLine();
            }

            for (int i = 0; i < subject.Length; i++)
            {
                string course = subject[i] + number[i];
                Console.WriteLine($"{course}");
            }
        }
    }
}
