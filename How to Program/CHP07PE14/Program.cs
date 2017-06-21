using System;

/**
 * 7.14 (Exponentiation) 
 * Write a method IntegerPower( base, exponent ) that returns the value of base exponent For example, 
 * IntegerPower( 3, 4 ) calculates 3^4 (or 3 * 3 * 3 * 3). Assume that exponent is a positive integer and that base 
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
            Console.WriteLine("Testing: {0}.", IntegerPower(4, 3));
        }      
        
        public static double IntegerPower(int baseNum, int power)
        {
            int product = 1;

            for (int i = 0; i < power; i++)
            {
                product *= baseNum;
            }

            return product;
        }
    }
}
