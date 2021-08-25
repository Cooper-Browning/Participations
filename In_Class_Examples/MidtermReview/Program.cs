using System;

namespace MidtermReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello WorldW";
            int indexOfTheFirstW = msg.IndexOf('W');

            Console.WriteLine(msg);
            Console.WriteLine(indexOfTheFirstW);
        }
    }
}
