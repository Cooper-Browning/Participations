using System;

namespace Conditionals_PPT_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {

            
                Console.WriteLine($"Please enter the # of miles >>");
                answer = Console.ReadLine();
                //double miles = Convert.ToDouble(answer);
                double miles;
                bool isSuccessful = double.TryParse(answer, out miles); //out miles allows it to store value in miles if it is successful

                if (isSuccessful == false)
                {
                    Console.WriteLine("Invalid input. Goodbye.");
                    //return; //goes past rest of code and ends it
                    Environment.Exit(-1); //stops application and assigns exit code of -1, good for debugging
                }

                Console.WriteLine($"Please enter the weight of you shipment in pounds >>");
                answer = Console.ReadLine();
                //double miles = Convert.ToDouble(answer);
                double weight;

                if (double.TryParse(answer, out weight) == false)
                {
                    Console.WriteLine("Invalid input. Goodbye.");
                    //return; //goes past rest of code and ends it
                    Environment.Exit(-2); //stops application and assigns exit code of -1, good for debugging
                }

                Console.WriteLine($"Does you shipment contain hazardous materials? Yes or No >>");
                answer = Console.ReadLine();

                double quote = .55 * miles + .73 * weight;

                double hazardousCost;
                if (answer.ToLower() == "yes")
                {
                    hazardousCost = .015 * weight;
                }
                else
                {
                    hazardousCost = 0;
                }

                double netTotal = quote + hazardousCost;
                double discount = 0;
                if (miles<150 && weight>500)
                {
                    discount = 0.10 * netTotal;
                }

                double total = netTotal - discount;

                Console.WriteLine($"Quote: \t\t{quote.ToString("C")}");
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Hazardous Cost: {hazardousCost.ToString("C")}");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Discount: \t{discount.ToString("C")}");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"Total: \t\t{total.ToString("C")}");

                Console.WriteLine("\nDo you want to enter another shipment? Yes or No?");
                answer = Console.ReadLine().ToLower();
                while(answer != "yes" && answer != "no")
                {
                    Console.WriteLine("YOU MUST SAY YES OR NO >>");
                    answer = Console.ReadLine().ToLower();
                }

            } while (answer == "yes");

            Console.WriteLine("\n\nGoodbye!");
        }
    }
}
