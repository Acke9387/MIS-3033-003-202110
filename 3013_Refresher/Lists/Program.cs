using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();

            bool shouldIContinue = true;

            while (shouldIContinue)
            {
                Console.WriteLine("Please enter your exam grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());

                examGrades.Add(grade);

                Console.WriteLine("Do you have another grade to enter? yes or no >>");

                if (Console.ReadLine().ToLower() != "yes")
                {
                    shouldIContinue = false;
                    break;
                }
            }

            double sum = 0;

            foreach (double grade in examGrades)
            {
                sum += grade;
            }

            Console.WriteLine($"Your average exam grade is {(sum/examGrades.Count).ToString("P")}");
        }
    }
}
