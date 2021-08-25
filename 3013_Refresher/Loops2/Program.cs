using System;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int examCount = 0;

            do
            {
                examCount++;
                Console.WriteLine($"Please enter your score for Exam {examCount.ToString("N0")} (e.g. 90% = .9) >>");
                sum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Do you have another score to enter? Yes or No >>");
            } while (Console.ReadLine().ToLower()[0] == 'y');

            Console.WriteLine($"Your average exam grade is {(sum/examCount).ToString("P")}");
            
        }
    }
}
