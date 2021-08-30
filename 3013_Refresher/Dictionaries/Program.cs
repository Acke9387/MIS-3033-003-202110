using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruits = new Dictionary<string, double>();

            fruits.Add("Apples", 0.99);
            fruits.Add("Oranges", 0.50);
            fruits.Add("Bananas", 0.50);
            fruits.Add("Grapes", 2.99);
            fruits.Add("Blueberries", 1.99);

            Console.WriteLine("What fruit would you like the price for? >>");
            string fruit = Console.ReadLine();

            if (fruits.ContainsKey(fruit) == true)
            {
                Console.WriteLine($"The price of {fruit}'s is {fruits[fruit].ToString("C")}");

            }
            else
            {
                Console.WriteLine($"We do not carry {fruit} here.  Go elsewhere.");
            }
        }
    }
}
