using System;
using System.Collections.Generic;
using System.IO;

namespace Classes_Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cereal> bowls = new List<Cereal>();
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            //[0] = "name|manufacturer|calories|cups" -- for loop
            //[1] = "100% Bran|Nabisco|70|0.33"


            //Read in all data from the dile and make Cereal objects and add those to ur bowls collection
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                //Line = "100% Bran|Nabisco|70|0.33"

                string[] pieces = line.Split('|');
                //              0             1       2      3      
                //pieces = {"100% Bran", "Nabisco", "70", "0.33"}
                Cereal c = new Cereal();
                c.Name = pieces[0];
                c.Manufacturer = pieces[1];
                c.Calories = Convert.ToDouble(pieces[2]); //must convert string to double
                c.Cups = Convert.ToDouble(pieces[3]);     //must convert string to double

                bowls.Add(c);
            }

            Console.WriteLine("Cereals with a serving size greater than or equal to 1:");
            //Go through bowls and output desired cereals
            foreach (Cereal bowl in bowls)
            {
                if (bowl.Cups >= 1)
                {
                    Console.WriteLine(bowl);
                }
            }

            Console.WriteLine("\nCereals that have 100 calories or less per serving");
            foreach (Cereal bowl in bowls)
            {
                if (bowl.Calories <= 100)
                {
                    Console.WriteLine(bowl);
                }
            }

        }
    }
}
