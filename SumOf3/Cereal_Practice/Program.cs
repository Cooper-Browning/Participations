using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cereal> bowls = new List<Cereal>();

            string[] lines = File.ReadAllLines("Cereal_Data (1).txt");

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                //100% Bran|Nabisco|70|0.33

                string[] pieces = line.Split('|');
                //    0         1    2  3
                //100% Bran|Nabisco|70|0.33

                Cereal c1 = new Cereal();
                c1.Name = pieces[0];
                c1.Manufacturer = pieces[1];
                c1.Calories = Convert.ToDouble(pieces[2]);
                c1.Cups = Convert.ToDouble(pieces[3]);

                bowls.Add(c1);

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cereals with 100 calories per serving or less:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Cereal bowl in bowls)
            {
                if (bowl.Calories <= 100)
                {
                    Console.WriteLine(bowl);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cereals with a serving size of one cup or more");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Cereal bowl in bowls)
            {
                if (bowl.Cups >= 1)
                {
                    Console.WriteLine(bowl);
                }
            }


        }
    }
}
