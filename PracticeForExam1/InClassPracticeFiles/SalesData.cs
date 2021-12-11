using System;
using System.Collections.Generic;
using System.Text;

namespace InClassPracticeFiles
{
    public class SalesData
    {
        public DateTime TransactionDate {get;set;}
        public string Product {get;set;}
        public double Price {get;set;}
        public string PaymentType {get;set;}
        public string Name {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public string Country {get;set;}
        public DateTime AccountCreated {get;set;}
        public DateTime LastLogin { get; set; }
        public double Latitude {get;set;}
        public double Longitude { get; set; }


        public SalesData()
        {
            TransactionDate = DateTime.Now;
            Product = string.Empty;
            Price = 0;
            PaymentType = string.Empty;
            Name = string.Empty;
            City = string.Empty;
            State = string.Empty;
            Country = string.Empty;
            AccountCreated = DateTime.Now;
            LastLogin = DateTime.Now;
            Latitude = 0;
            Longitude = 0;

        }

        public override string ToString()
        {
            return $"{PaymentType}, {Product}";
        }
    }
}
