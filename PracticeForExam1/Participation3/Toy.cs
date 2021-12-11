using System;
using System.Collections.Generic;
using System.Text;

namespace Participation3
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Image = string.Empty;
            Aisle = string.Empty;
        }

        public string GetAisle()
        {
            return $"{Manufacturer.ToUpper()[0]}{Price.ToString().Replace(".", "")}";
        }

        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }
    }
}
