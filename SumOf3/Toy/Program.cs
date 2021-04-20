using System;
using System.Collections.Generic;

namespace Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toy> ToyBox = new List<Toy>();

            Toy RaceCar = new Toy();
            RaceCar.Manufacturer = "Toyota";
            RaceCar.Name = "RaceCar";
            RaceCar.Price = 24.99;
            RaceCar.SetNotes("Super fast wind-up car");

            Toy ActionFigure = new Toy("Hasbro", "Red Power Ranger", 14.99, "This action figure comes with a power ranger sticker.");

            ToyBox.Add(RaceCar);
            ToyBox.Add(ActionFigure);

            RaceCar.ToyInfo();
            ActionFigure.ToyInfo();
            Console.WriteLine(RaceCar.ToString());

            //printing out again to see if my method ViewToyBox works
            Console.WriteLine();
            ViewToyBox(ToyBox);
        }

        /// <summary>
        /// Extra stuff. Prints info for each toy in toybox
        /// </summary>
        /// <param name="toybox"></param>
        static void ViewToyBox(List<Toy> toybox)
        {
            for (int i = 0; i < toybox.Count; i++)
            {
                toybox[i].ToyInfo();
            }
        }
    }
}
