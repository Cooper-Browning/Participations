using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Cooper", "Functions_Calculator", "4/1/2021");

            string calcAnswer;
            double value1;
            double value2;
            
            double answer;

            Console.WriteLine("What type of calculation would you like to preform: Add, Subtract, Multiply, Divide");
            calcAnswer = Console.ReadLine().ToLower();
            Console.WriteLine("What is the first value?");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the second value?");
            value2 = Convert.ToDouble(Console.ReadLine());

            if (calcAnswer == "add")
            {
                answer = Add(value1, value2);
                Console.WriteLine($"Answer = {answer}");
            }
            else if (calcAnswer == "subtract")
            {
                answer = Subtract(value1, value2);
                Console.WriteLine($"Answer = {answer}");
            }
            else if (calcAnswer == "multiply")
            {
                answer = Multiply(value1, value2);
                Console.WriteLine($"Answer = {answer}");
            }
            else
            {
                answer = Divide(value1, value2);
                Console.WriteLine($"Answer = {answer}");
            }

            string response;
            do
            {
                Console.WriteLine($"Press 0 to exit application.\nPress 1 to run a new calculation.\nPress 2 to use the previous result as the first number in a new calculation.");
                response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("What type of calculation would you like to preform: Add, Subtract, Multiply, Divide");
                    calcAnswer = Console.ReadLine().ToLower();
                    Console.WriteLine("What is the first value?");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is the second value?");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    if (calcAnswer == "add")
                    {
                        answer = Add(value1, value2);
                        Console.WriteLine($"Answer = {answer}");
                    }
                    else if (calcAnswer == "subtract")
                    {
                        answer = Subtract(value1, value2);
                        Console.WriteLine($"Answer = {answer}");
                    }
                    else if (calcAnswer == "multiply")
                    {
                        answer = Multiply(value1, value2);
                        Console.WriteLine($"Answer = {answer}");
                    }
                    else
                    {
                        answer = Divide(value1, value2);
                        Console.WriteLine($"Answer = {answer}");
                    }
                }
                else if (response == "2")
                {
                    Console.WriteLine("What type of calculation would you like to preform: Add, Subtract, Multiply, Divide");
                    calcAnswer = Console.ReadLine().ToLower();
                    value1 = answer;
                    Console.WriteLine($"Value 1 is equal to the previous answer {answer}. What is the second value?");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    if (calcAnswer == "add")
                    {
                        answer = Add(value1, value2);
                        Console.WriteLine($"Answer = {answer}");
                    }
                    else if (calcAnswer == "subtract")
                    {
                        answer = Subtract(value1, value2);
                        Console.WriteLine($"Answer = {answer}");
                    }
                    else if (calcAnswer == "multiply")
                    {
                        answer = Multiply(value1, value2);
                        Console.WriteLine($"Answer = {answer}");
                    }
                    else
                    {
                        answer = Divide(value1, value2);
                        Console.WriteLine($"Answer = {answer}");
                    }
                }

            } while (response == "1" || response == "2");

            Console.WriteLine("Thank you for your service. Closing application now.");



        }

        static double Add(double val1, double val2)
        {
            double sum = val1 + val2;
            return sum;

            //return val1 + val2;
        }

        static double Subtract(double val1, double val2)
        {
            double answer = val1 - val2;
            return answer;


        }

        static double Multiply(double val1, double val2)
        {
            double answer = val1 * val2;
            return answer;


        }

        static double Divide(double val1, double val2)
        {
            double answer = val1 / val2;
            return answer;


        }

        static void DeveloperInformation(string developerName, string className, string dateWritten)
        {
            Console.WriteLine($"{developerName} wrote this application for the class {className}. It was written on {dateWritten}");
        }
    }
}
