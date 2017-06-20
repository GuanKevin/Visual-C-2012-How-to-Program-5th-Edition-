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
            Console.Write("Enter number one: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number two: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The GCD of {0} and {1} is {2}.", number1, number2, GCD(number1, number2));
        }

        public static int GCD(int number1, int number2)
        {
            int min = Math.Min(number1, number2);

            for (int i = min; i >= 1; i--)
                if (((number1 % i) == 0) && ((number2 % i) == 0))
                    return i;

            return 1;
        }
    }
}
