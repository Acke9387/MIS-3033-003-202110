using System;

namespace Conditionals
{
    class Program
    {
        const double COG_COST = 79.99;
        const double GEAR_COST = 250.00;
        const double SALES_TAX = 0.089;
        const double STANDARD_MARKUP_PERCENTAGE = 0.15;
        const double DISCOUNTED_MARKUP_PERCENTAGE = 0.125;

        static void Main(string[] args)
        {

            Console.WriteLine($"Please enter the # of gears? >>");
            string answer = Console.ReadLine();

            int cogs, gears;
            if (int.TryParse(answer, out gears) == false)
            {
                Console.WriteLine("Invalid entry for # of gears.  Goodbye.");
                Environment.Exit(-5);
            }

            Console.WriteLine($"Please enter the # of cogs? >>");
            answer = Console.ReadLine();
            if (int.TryParse(answer, out cogs) == false)
            {
                Console.WriteLine("Invalid entry for # of cogs.  Goodbye.");
                Environment.Exit(-5);
            }

            double markup;

            //if (cogs >= 10)
            //{
            //    markup = DISCOUNTED_MARKUP_PERCENTAGE;
            //}
            //else if(gears >= 10)
            //{
            //    markup = DISCOUNTED_MARKUP_PERCENTAGE;
            //}
            //else
            //{
            //    if ((gears+cogs) >= 16)
            //    {
            //        markup = DISCOUNTED_MARKUP_PERCENTAGE;
            //    }
            //    else
            //    {
            //        markup = STANDARD_MARKUP_PERCENTAGE;
            //    }
            //}
            if (cogs >= 10 || gears >= 10 || (gears + cogs) >= 16)
            {
                markup = DISCOUNTED_MARKUP_PERCENTAGE;
            }
            else
            {
                markup = STANDARD_MARKUP_PERCENTAGE;
            }

            double cogCostAtStandard = COG_COST * (1+STANDARD_MARKUP_PERCENTAGE);
            double cogCostAtMarkup = COG_COST * (1 + markup);
            
            double gearCostAtStandard = GEAR_COST * (1 + STANDARD_MARKUP_PERCENTAGE);
            double gearCostAtMarkup =   GEAR_COST * (1 + markup)    ;

            double cogTotal = cogCostAtMarkup * cogs;
            double gearTotal = gearCostAtMarkup * gears;

            double cogSavings = (cogCostAtStandard * cogs) - cogTotal;
            double gearSavings = (gearCostAtStandard * gears) - gearTotal;
            double savings = cogSavings + gearSavings;

            double salesTax = (cogTotal + gearTotal) * SALES_TAX;

            Console.WriteLine($"Cogs @ {cogCostAtMarkup.ToString("C")} x {cogs} = {cogTotal.ToString("C")}");
            Console.WriteLine($"Gears @ {gearCostAtMarkup.ToString("C")} x {gears} = {gearTotal.ToString("C")}");
            Console.WriteLine($"Total: {(cogTotal + gearTotal).ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Savings : {savings.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Sales Tax : {salesTax.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
