using System;
using System.Collections.Generic;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<int, List<Receipt>> receipts = new Dictionary<int, List<Receipt>>();
            string answer;

            do
            {
                
                int cogs = ValidateIntegerInput("Enter the quantity of cogs: ", "Sorry that is invalid. Please enter a valid value.");
                int gears = ValidateIntegerInput("Enter the quantity of gears: ", "Sorry that is invalid. Please enter a valid value.");
                int CustId = ValidateIntegerInput("Enter the customer id: ", "Sorry that is invalid. Please enter a valid value.");

                Receipt receipt = new Receipt(CustId, cogs, gears);

                if (receipts.ContainsKey(CustId) == false)
                {
                    receipts.Add(CustId, new List<Receipt>());
                }
                receipts[CustId].Add(receipt);



                Console.WriteLine("Do you want to enter information for another receipt? (Yes or No)");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            do
            {
                DisplayOptions();
                answer = Console.ReadLine();

                int option = 0;
                while (int.TryParse(answer, out option) == false || (option !=3 && option !=2 && option !=1))
                {
                    Console.WriteLine($"{answer} was not a valid input. Please look at the menu and input a number between 1 and 3.");
                    DisplayOptions();
                    answer = Console.ReadLine();
                }

                switch (option)
                {
                    case 1: //Customer ID
                        int id = ValidateIntegerInput("Please enter the customer id that you want to see the receipts for:", "Sorry that was not a valid customer id. Please enter an actual customer id.");
                        DisplayReceiptsByCustomerID(receipts, id);

                        break;
                    case 2: //All of today's receipts
                        DisplayReceiptsForToday(receipts);

                        break;
                    case 3: //Highest Total
                        DisplayReceiptWithHighestTotal(receipts);

                        break;
                }

                Console.WriteLine("Do you want to display more receipts? (Yes or No)");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            Console.WriteLine("Goodbye");
        }

        private static void DisplayReceiptWithHighestTotal(Dictionary<int, List<Receipt>> receipts)
        {
            double highest = -1;

            foreach (var customer in receipts.Keys)
            {
                foreach (var receipt in receipts[customer])
                {
                    if (receipt.CalculateTotal() > highest)
                    {
                        highest = receipt.CalculateTotal();
                    }
                }
            }

            foreach (var customer in receipts.Keys) //To print the exact highest receipt, not all the customer's receipts with that ID
            {
                foreach (var receipt in receipts[customer])
                {
                    if (receipt.CalculateTotal() == highest)
                    {
                        receipt.PrintReceipt();
                    }
                }
            }
        }

        private static void DisplayReceiptsForToday(Dictionary<int, List<Receipt>> receipts)
        {
            foreach (var customer in receipts.Keys)
            {
                foreach (var receipt in receipts[customer])
                {
                    if (receipt.SaleDate.Date == DateTime.Now.Date)
                    {
                        receipt.PrintReceipt();
                    }
                }
            }
        }

        private static void DisplayReceiptsByCustomerID(Dictionary<int, List<Receipt>> receipts, int id)
        {
            if (receipts.ContainsKey(id) == false)
            {
                Console.WriteLine($"Sorry there are no receipts for a customer with the id of: {id}");
            }
            else
            {
                foreach (var receipt in receipts[id])
                {
                    receipt.PrintReceipt();
                }
            }

        }

        /// <summary>
        /// Asks user a message and makes sure they provide an integer answer. Will keep prompting with repromt message until they meet our demands.
        /// </summary>
        /// <param name="initialMessage">First message to show user</param>
        /// <param name="repromptMessage">Message to show the user if they provide any invalid input</param>
        /// <returns>A valid integer for the question asked in the initial message.</returns>
        private static int ValidateIntegerInput(string initialMessage, string repromptMessage)
        {
            int value;
            string input;
            Console.WriteLine(initialMessage);
            input = Console.ReadLine();

            while (int.TryParse(input, out value) == false)
            {
                Console.WriteLine(repromptMessage);
                input = Console.ReadLine();
            }

            return value;

        }

        private static void DisplayOptions()
        {
            Console.WriteLine("".PadRight(15, '#'));
            Console.WriteLine("\tOptions");
            Console.WriteLine("1. By CustomerID");
            Console.WriteLine("2. All of todays receipts");
            Console.WriteLine("3. Receipt with highest total");
            Console.WriteLine("".PadRight(15, '#'));
            Console.WriteLine();
        }
    }
}
