using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Example1
{
    public class Circle
    {

        public double Radius { get; set; }

        /// <summary>
        /// Default/empty constructor setting radius to 0
        /// </summary>
        public Circle()
        {
            Radius = 0;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius; 
        }

    }
}
