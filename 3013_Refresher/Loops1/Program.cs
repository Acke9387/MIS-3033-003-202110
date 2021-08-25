using System;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please enter your score for Exam {i+1}. >>");
                sum += Convert.ToDouble(Console.ReadLine());
                //sum = sum + ...
            }

            double average = sum / 3;
            average /= 100;
            Console.WriteLine($"Your average exam grade is {average.ToString("P2")}.");
        }
    }
}
