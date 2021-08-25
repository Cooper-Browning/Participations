using System;
using System.Collections.Generic;
using System.IO;

namespace DogShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dogs = File.ReadAllLines("Dogs.csv");

            Dictionary<string, Dog> dogShelter = new Dictionary<string, Dog>();

            for (int i = 1; i < dogs.Length; i++)
            {
                string line = dogs[i];
                string[] pieces = line.Split(',');
                //  0   1     2          3        
                //Zeus,Husky,Yes,Kong; Rope; Tennis Ball
                Dog d1 = new Dog();
                d1.Name = pieces[0];
                d1.Breed = pieces[1];
                if (pieces[2].ToLower() == "yes")
                {
                    d1.BeenWalked = true;
                }
                else
                {
                    d1.BeenWalked = false;
                }

                string[] moreToys = pieces[3].Split(';');
                foreach (string toy in moreToys)
                {
                    d1.Toys.Add(toy);
                }

                dogShelter.Add(d1.Name, d1);
            }

            dogShelter["Shiner"].AddToy("frisbee");
            dogShelter["Todo"].WalkDog();

            AddDog(dogShelter);    

            foreach (Dog pup in dogShelter.Values)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(pup.ToString());
                Console.ForegroundColor = ConsoleColor.White;
                pup.ShowToys();
            }




        }

        static void AddDog(Dictionary<string, Dog> doge)
        {
            string done;

            do
            {
                Dog dogAdding = new Dog();
                Console.WriteLine("What is the name of the dog you are adding to the shelter:");
                dogAdding.Name = Console.ReadLine();
                Console.WriteLine("What breed is the dog:");
                dogAdding.Breed = Console.ReadLine();
                Console.WriteLine("Has the dog been walked: yes or no");
                string walked = Console.ReadLine();
                if (walked.ToLower()[0] == 'y')
                {
                    dogAdding.BeenWalked = true;
                }
                else
                {
                    dogAdding.BeenWalked = false;
                }
                string more;
                do
                {
                    Console.WriteLine($"What toy does {dogAdding.Name} like?");
                    dogAdding.Toys.Add(Console.ReadLine());

                    Console.WriteLine($"Is there anther toy the dog likes? yes or no");
                    more = Console.ReadLine();

                } while (more.ToLower()[0] == 'y');

                doge.Add(dogAdding.Name, dogAdding);

                Console.WriteLine("Is there another dog you want to add to the shelter:");
                done = Console.ReadLine();

            } while (done.ToLower()[0] == 'y');


        }
    }
}
