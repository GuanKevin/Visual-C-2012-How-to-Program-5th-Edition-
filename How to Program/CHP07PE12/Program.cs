using System;

/**
 * 7.12 Write statements that assign random integers to the variable n in the following ranges. 
 * Assume Random randomNumbers = new Random() has been defined and use the two-parameter version of the method 
 * Random.Next.
 * a) 1 ≤ n ≤2 
 * b) 1 ≤ n ≤100
 * c) 0 ≤ n ≤9
 * d) 1000 ≤ n ≤1112
 * e) –1 ≤ n ≤1
 * f) –3 ≤ n ≤11
 */ 
namespace CHP07PE12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    if (j + 1 % 10 == 0)
                        Console.WriteLine("{0} ", randomNumbers.Next(-3, 12));
                    else
                        Console.Write("{0} ", randomNumbers.Next(-3, 12));
                Console.WriteLine();
            }
        }
    }
}
