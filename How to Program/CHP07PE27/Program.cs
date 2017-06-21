using System;

/**
 * 7.27 (Greatest Common Divisor) 
 * The greatest common divisor (GCD) of two integers is the largest integer that evenly divides each of the two numbers. 
 * Write method Gcd that returns the greatest common divisor of two integers. Incorporate the method into an app that 
 * reads two values from the user and displays the result.
 */ 
namespace CHP07PE27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The GCD is {0}", GCD(10, 20));
        }

        public static int GCD(int number1, int number2)
        {
            int smallest = Math.Min(number1, number2);

            for (int i = smallest; i >= 2; i--)
            {
                if (number1 % i == 0 & number2 % i == 0)
                    return i;                
            }
            return 1;
        }
    }
}