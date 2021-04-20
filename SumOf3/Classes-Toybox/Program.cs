using System;

namespace Classes_Toybox
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox myToys = new ToyBox();
            Console.WriteLine("What is your name?");
            myToys.Owner = Console.ReadLine();
            Console.WriteLine("Where do you keep your toybox?");
            myToys.Location = Console.ReadLine();

            string moreToys;
            do
            {
                Console.WriteLine("Who is the manufacturer of the toy?");
                string man = Console.ReadLine();
                Console.WriteLine("What is the name of your toy?");
                string name = Console.ReadLine();
                Console.WriteLine("What was the price of your toy?");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What notes do you want to add for the toy?");
                string notes = Console.ReadLine();
                myToys.Toys.Add(new Toy(man, name, price, notes));

                Console.WriteLine("Would you like to enter another toy into your toybox?");
                moreToys = Console.ReadLine();


            } while (moreToys.ToLower()[0] == 'y');



            Console.WriteLine(myToys.GetRandomToy().ToString());
        }
    }
}
