using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Example1
{
    public class Rectangle
    {
        /*
        private double _Width; //cannot be directly accessed by user because private

        public double GetWidth() // allows user to get the value of width but not change it
        {
            return _Width;
        }

        public void SetWidth(double width) //allows user to set the value of width
        {
            _Width = width;
        }
        */
        public double Length { get; set; } // allows use the ability to get and set variable, can be directly accessed by user because public
        public double Width { get; set; }

        /// <summary>
        /// Overloaded constructor, where we know what values we want Length and Width to be
        /// </summary>
        /// <param name="width">Width of Rectangle</param>
        /// <param name="length">Length of Rectangle</param>
        public Rectangle(double width, double length) //local variables are lowercase
        {
            Width = width;
            Length = length;
        }

        /// <summary>
        /// Default/ empty constructor that sets this instance of a Rectangle to starting values
        /// </summary>
        public Rectangle() //type ctor and hit tab twice. ctor short for constructor
        {
            Length = 5;
            Width = 5;
        }

        /// <summary>
        /// Calculates the Area of this Rectangle
        /// </summary>
        /// <returns> area as type double</returns>
        public double CalculateArea()
        {
            return Length * Width; 
        }
        
        /// <summary>
        /// Calculates the Perimeter of this Rectangle
        /// </summary>
        /// <returns>The perimeter of this Rectangle</returns>
        public double CalculatePerimeter()
        {
            return 2 * (Width + Length);
        }
    }
}
