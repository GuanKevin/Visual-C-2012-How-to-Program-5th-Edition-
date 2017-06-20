using System;

/**
 * 7.13 
 * For each of the following sets of integers, write a single statement that will display a number at random from the set. 
 * Assume Random randomNumbers = new Random() has been defined and use the one-parameter version of method Random.Next.
 * a) 2, 4, 6, 8, 10.
 * b) 3, 5, 7, 9, 11.
 * c) 6, 10, 14, 18, 22.
 */ 
namespace CHP07PE13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();

            for (int i = 0; i < 100; i++)
                if ((i + 1) % 10 == 0)
                    Console.WriteLine("{0}\t", ((randomNumbers.Next(1, 6) * 2) + 1) * 2);
                else
                    Console.Write("{0}\t", ((randomNumbers.Next(1, 6) * 2) + 1) * 2);
        }
    }
}
