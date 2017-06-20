using System;

/**
 * 7.14 (Exponentiation) 
 * Write a method IntegerPower( base, exponent ) that returns the value of base exponent For example, 
 * IntegerPower( 3, 4 ) calculates 34 (or 3 * 3 * 3 * 3). Assume that exponent is a positive integer and that base 
 * is an integer. Method IntegerPower should use a for or while loop to control the calculation. Do not use any 
 * Math-library methods. Incorporate this method into an app that reads integer values for base and exponent and 
 * performs the calculation with the IntegerPower method.
 */ 
namespace CHP07PE14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The exponentiation is: {0}.", IntegerPower(value, exponent));
        }

        public static int IntegerPower(int value, int exponent)
        {
            int sum = 1;

            for (int i = 0; i < exponent; i++)
                sum *= value;

            return sum;
        }
    }
}
