using System;

/**
 * 6.12 (Product of Odd Integers) 
 * Write an app that calculates the product of the odd integers from 1 to 7.
 */ 
namespace CHP06PE12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;

            Console.Write("{0}", sum);
            for (int i = 3; i <= 7; i += 2)
            {
                sum *= i;
                Console.Write(" * {0}", i);
            }

            Console.WriteLine("\nThe product of Odd Integers from 1 to 7 is {0}.", sum);
        }
    }
}
