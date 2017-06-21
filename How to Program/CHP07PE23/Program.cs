using System;

/**
 * 7.23 (Find the Minimum) 
 * Write a method Minimum3 that returns the smallest of three floating point numbers. Use the Math.Min method to implement 
 * Minimum3. Incorporate the method into an app that reads three values from the user, determines the smallest value and 
 * displays the result.
 */ 
namespace CHP07PE23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum: {0}", Minimum3(3, 1.1, 5.3));
        }

        public static double Minimum3(double min1, double min2, double min3)
        {
            min1 = Math.Min(min1, min2);
            
            return Math.Min(min1, min3);
        }
    }
}
