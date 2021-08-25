using System;
using System.Collections.Generic;

namespace Classes_Toybox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> AllToyBoxes = new List<ToyBox>();
            string moreToyBoxes;
            int toyIndex = 0;
            do
            {
                
                ToyBox BoxAdding = new ToyBox();
                Console.WriteLine("Who is the owner of this toybox?");
                BoxAdding.Owner = Console.ReadLine();
                Console.WriteLine("Where is this toybox kept?");
                BoxAdding.Location = Console.ReadLine();
                AllToyBoxes.Add(BoxAdding);

                string moreToys;
                do
                {
                    Console.WriteLine("What is the name of your toy you want to add to this toybox?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Who is the manufacturer of the toy?");
                    string man = Console.ReadLine();
                    Console.WriteLine("What was the price of your toy?");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What notes do you want to add for the toy?");
                    string notes = Console.ReadLine();
                    AllToyBoxes[toyIndex].Toys.Add(new Toy(man, name, price, notes));

                    Console.WriteLine("Would you like to enter another toy into your toybox?");
                    moreToys = Console.ReadLine();


                } while (moreToys.ToLower()[0] == 'y');

                Console.WriteLine("Do you have another toybox with toys that you want to add?");
                moreToyBoxes = Console.ReadLine();

                toyIndex++;

            } while (moreToyBoxes.ToLower()[0] == 'y');

            for (int i = 0; i < AllToyBoxes.Count; i++)
            {
                Console.WriteLine($"\nContents of ToyBox {i + 1}:\n");
                for (int j = 0; j < AllToyBoxes[i].Toys.Count; j++)
                {
                    Console.WriteLine(AllToyBoxes[i].Toys[j].ToString());
                }
            }

            for (int i = 0; i < AllToyBoxes.Count; i++)
            {
                Console.WriteLine($"\nRandom toy in toybox {i + 1}:\n");
                Console.WriteLine(AllToyBoxes[i].GetRandomToy().ToString());
            }

        }
    }
}
