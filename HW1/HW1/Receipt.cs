using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    public class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }

        private double SalesTaxPercent;
        private double CogPrice;
        private double GearPrice;


        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = .089;
            CogPrice = 79.99;
            GearPrice = 250.00;
        }

        public Receipt(int id, int cog, int gear)
        {
            CustomerID = id;
            CogQuantity = cog;
            GearQuantity = gear;
            SaleDate = DateTime.Now;
            SalesTaxPercent = .089;
            CogPrice = 79.99;
            GearPrice = 250.00;
        }

        public double CalculateTotal()
        {
            return CalculateNetAmount() + CalculateTaxAmount();
        }

        public void PrintReceipt()
        {
            string receipt = $"\t{string.Empty.PadLeft(40, '#')}\n" +
                             $"\t{"".PadLeft(05, ' ') + "Customer:"} {CustomerID}\n" +
                             $"\t{string.Empty.PadLeft(40, '-')}\n" +
                             $"\t{"# Of Cogs:".PadRight(15, ' ')}{CogQuantity.ToString("N0")}\n" +
                             $"\t{"# Of Gears:".PadRight(15, ' ')}{GearQuantity.ToString("N0")}\n" +
                             $"\t{"SubTotal:".PadRight(15, ' ')}{CalculateNetAmount().ToString("C")}\n" +
                             $"\t{"Sales Tax:".PadRight(15, ' ')}{CalculateTaxAmount().ToString("C")}\n" +
                             $"\t{"Total:".PadRight(15, ' ')}{CalculateTotal().ToString("C")}\n" +
                             $"\t{string.Empty.PadLeft(40, '#')}\n";
            Console.WriteLine(receipt);
        }

        private double CalculateTaxAmount()
        {
            return CalculateNetAmount() * SalesTaxPercent;
        }

        private double CalculateNetAmount()
        {
            double netAmount;
            double cogsPriceMarkup = .15;
            double gearsPriceMarkup = .125;

            if (CogQuantity > 10 || GearQuantity > 10 || (CogQuantity + GearQuantity) > 16)
            {
                cogsPriceMarkup = CogPrice + CogPrice * .125;
                gearsPriceMarkup = GearPrice + GearPrice * .125;
            }
            else
            {
                cogsPriceMarkup = CogPrice + CogPrice * .15;
                gearsPriceMarkup = GearPrice + GearPrice * .15;
            }
            netAmount = (CogQuantity * cogsPriceMarkup) + (GearQuantity * gearsPriceMarkup);
            return netAmount;
        }
    }

}
