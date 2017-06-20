using System;

/**
 * 5.38 (Infinite Series: Mathematical Constant e) 
 * Write an app that estimates the value of the mathematical constant e by using the formula The predefined constant 
 * Math.E (class Math is in the System namespace) provides a good approximation of e. Use the WriteLine method to 
 * output both your estimated value of e and Math.E for comparison.
 */ 
namespace CHP05PE38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double e = 1;
            int numCounter = 0;

            while (numCounter < number)
            {
                e += (1.0 / Factorial(++numCounter));
            }

            Console.WriteLine("My way: {0}.", e);
            Console.WriteLine("Built in: {0}.", Math.E);
        }

        public static double Factorial(int number)
        {
            int sum = 1;

            while (number > 0)
            {
                sum *= number--;
            }

            return sum;
        }
    }
}
