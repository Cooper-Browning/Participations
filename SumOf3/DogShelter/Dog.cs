using System;
using System.Collections.Generic;
using System.Text;

namespace DogShelter
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public bool BeenWalked { get; set; }
        public List<string> Toys { get; set; }

        public Dog()
        {
            Name = String.Empty;
            Breed = String.Empty;
            BeenWalked = false;
            Toys = new List<string>();
        }

        public override string ToString()
        {
            return $"Dog Name: {Name} Breed: {Breed} Has been walked: {BeenWalked}";
        }

        public void WalkDog()
        {
            if (BeenWalked)
            {
                Console.WriteLine($"{Name} has already been walked.");
            }
            else
            {
                BeenWalked = true;
                Console.WriteLine($"{Name} has now been walked");
            }
        }

        public void AddToy(string toy)
        {
            Toys.Add(toy);
        }

        public void ShowToys()
        {
            Console.WriteLine($"{Name}'s toys include:");
            foreach (string toy in Toys)
            {
                Console.WriteLine(toy);
            }
        }

        
    }
}
