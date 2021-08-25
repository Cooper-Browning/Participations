using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toybox
{
    public class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }

        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = String.Empty;
            Location = String.Empty;
        }

        public Toy GetRandomToy()
        {
            Random rand = new Random();
            return Toys[rand.Next(0, Toys.Count)];
        }

    }
}
