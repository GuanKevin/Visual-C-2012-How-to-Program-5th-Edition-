using System;

/**
 * 7.23 (Find the Minimum) 
 * Write a method Minimum3 that returns the smallest of three floatingpoint numbers. Use the Math.Min method to implement 
 * Minimum3. Incorporate themethod into an app that reads three values from the user, determines the smallest value and 
 * displays the result.
 */ 
namespace CHP07PE23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter floating point number 1: ");
            float num1 = (float) Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter floating point number 2: ");
            float num2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter floating point number 3: ");
            float num3 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The smallest amongst {0}, {1}, and {2} is {3}.", num1, num2, num3, Minimum3(num1, num2, num3));
        }

        public static float Minimum3(float num1, float num2, float num3)
        {
            num1 = Math.Min(num1, num2);

            return Math.Min(num1, num3);
        }
    }
}
