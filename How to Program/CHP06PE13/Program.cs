using System;

/**
 * 6.13 (Factorials) 
 * Factorials are used frequently in probability problems. The factorial of a positive integer n 
 * (written n! and pronounced “n factorial”) is equal to the product of the positive integers from 1 to n. 
 * Write an app that evaluates the factorials of the integers from 1 to 5.Display the results 
 * in tabular format. What difficulty might prevent you from calculating the factorial of 20?
 */
namespace CHP06PE13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number{0, 10}", "Factorial");

            for (int i = 1; i <= 5; i++)
            {
                int sum = 1;
                for (int j = 1; j <= i; j++)
                {
                    sum *= j;
                }
                Console.WriteLine("{0}{1, 15}", i, sum);
            }
        }
    }
}
