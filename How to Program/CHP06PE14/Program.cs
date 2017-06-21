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

            Console.WriteLine("Year{0, 20}{1, 10}", "Amount on deposit", "Rate");

            for (int i = 5; i <= 10; i++)
            {
                for (int year = 1; year <= 10; ++year)
                {
                    amount = principle * ((decimal)Math.Pow(1.0 + (i / 100.0), year));
                    Console.WriteLine("{0, 4}{1, 20:C}{2, 10}", year, amount, (i / 100.0));
                }
                Console.WriteLine();
            }
        }
    }
}
