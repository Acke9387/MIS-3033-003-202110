using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double spongebob = LineValueForY(.75, 7, 0);
            Console.WriteLine($"y = (.75)7 + 0 ==> {spongebob.ToString("N2")}");

            int val1 = Factorial(5);
            Console.WriteLine($"5! = {val1.ToString("n0")}");

            Console.WriteLine("Please enter a number to calculate the factorial of >>");
            Console.WriteLine($"The value is {Factorial(Convert.ToInt32(Console.ReadLine()))}");

        }


        /// <summary>
        /// Calculate the Y value of a line
        /// </summary>
        /// <param name="m">The slope of the line</param>
        /// <param name="x">The x-value of the line</param>
        /// <param name="b">The y-intercept of the line</param>
        /// <returns>The y-value of the line</returns>
        static double LineValueForY(double m, double x, double b)
        {
            double y = 0;

            y = m * x + b;
            return y;
        }

        /// <summary>
        /// Calculates the factorial of a value
        /// </summary>
        /// <param name="number">The number to calculate the factorial of</param>
        /// <returns>The value for the factorial</returns>
        static int Factorial (int number)
        {
            //ctrl + k , ctrl + d    format document
            //5!

            int value = 1;

            for (int i = number; i > 0; i--)
            {
                value *= i;
            }

            return value;
        }

    }
}
