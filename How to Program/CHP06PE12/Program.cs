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
            int oddProduct = 1;

            Console.Write(oddProduct);
            for (int i = 3; i <= 7; i += 2)
            {
                Console.Write(" * {0}", i);
                oddProduct *= i;
            }
            Console.WriteLine(" = {0}.", oddProduct);
        }
    }
}
