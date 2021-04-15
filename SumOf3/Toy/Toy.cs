using System;
using System.Collections.Generic;
using System.Text;

namespace Toy
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;

        public Toy()
        {
            Manufacturer = String.Empty;
            Name = String.Empty;
            Price = 0;
            Notes = "No notes";
        }

        public Toy(string man, string name, double price, string notes)
        {
            Manufacturer = man;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string GetNotes()
        {
            return Notes;
        }

        public void SetNotes(string notes)
        {
            Notes = notes;
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int aisle = rand.Next(1, 25);
            return Manufacturer.ToUpper()[0] + aisle.ToString();
        }

        public void ToyInfo()
        {
            Console.WriteLine($"Toy Name: {Name.PadRight(25)}Toy Manufacturer: {Manufacturer.PadRight(10)}Toy Price: {Price.ToString().PadRight(8)}Toy Aisle: {GetAisle()}\nToy Notes: {Notes}");
        }

    }
}
