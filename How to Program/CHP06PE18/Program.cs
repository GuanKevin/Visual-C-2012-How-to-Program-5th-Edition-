using System;

/**
 * 6.18 (Modified Compound Interest Program) 
 * In the future, you may work with other programming languages that do not have a type like decimal which supports 
 * precise monetary calculations. In those languages, you should perform such calculations using integers. Modify the app 
 * in Fig. 6.6 to use only integers to calculate the compound interest. Treat all monetary amounts as integral numbers of 
 * pennies. Then break the result into its dollars and cents portions by using the division and remainder operations, 
 * respectively. Insert a period between the dollars and the cents portions when you display the results.
 */ 
namespace CHP06PE18
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount, cent;
            int principal = 1000;
            double rate = 0.05;

            Console.WriteLine("Year{0, 20}", "Amount on deposit");

            for (int year = 1; year <= 10; ++year)
            { 
                amount = (int)((principal * (Math.Pow(1.0 + rate, year))) * 100);
                cent = amount % 100;
                amount /= 100;

                Console.WriteLine("{0, 4}{1, 20}.{2}", year, amount, cent);
            }
        }
    }
}
