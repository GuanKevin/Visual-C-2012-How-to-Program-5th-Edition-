using System;

/**
 * 7.25 (Prime Numbers) 
 * An integer is said to be prime if it’s greater than 1 and divisible by only 1 and itself. For example, 2, 3, 5 and 7 
 * are prime, but 4, 6, 8 and 9 are not. 
 * a) Write a method that determines whether a number is prime.
 * b) Use this method in an app that displays all the prime numbers less than 10,000.
 * c) Initially, you might think that n/2 is the upper limit for which you must test to see whether a number is prime, 
 * but you need only go as high as the square root of n. Rewrite the app, and run it both ways.
 */ 
namespace CHP07PE25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers");
            for (int i = 2; i < 100; i++)
                if (IsPrime(i))
                    Console.WriteLine(i);
        }

        public static Boolean IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if ((number % i) == 0)
                    return false;

            return true;
        }
    }
}
