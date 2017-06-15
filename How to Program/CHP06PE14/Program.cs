using System;

/**
 * 6.14 (Modified Compound Interest Program) 
 * Modify the compound-interest app (Fig. 6.6) to repeat its steps for interest rates of 5, 6, 7, 8, 9 and 10%. 
 * Use a for loop to vary the rate.
 */ 
namespace CHP06PE14
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount;
            decimal principle = 1000;
            double rate = 0.05;

            Console.WriteLine("Year{0, 20}", "Amount on deposit");

            for (int year = 1; year <= 10; ++year)
            {
                amount = principle * ((decimal)Math.Pow(1.0 + rate, year));
                Console.WriteLine("{0, 4}{1, 20:C}", year, amount);
            }
        }
    }
}
