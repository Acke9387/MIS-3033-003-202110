using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Files
{
    public class SalesData
    {
        public DateTime Transaction_date { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public string Payment_Type { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime Account_Created { get; set; }
        public DateTime Last_Login { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public SalesData()
        {
            Transaction_date = DateTime.Now ;
            Product = string.Empty;
            Price = 0;
            Payment_Type = string.Empty;
            Name = string.Empty;
            City = string.Empty;
            State = string.Empty;
            Country = string.Empty;
            Account_Created = DateTime.Now;
            Last_Login =      DateTime.Now;
            Latitude =  0;
            Longitude = 0;
        }

    }
}
