using System;

/**
 * 7.9 (Rounding to Nearest Integer) 
 * An app of method Math.Floor is rounding a value to the nearest integer. The statement y = Math.Floor( x + 0.5 ); will 
 * round the number x to the nearest integer and assign the result to y. Write an app that reads double values and uses 
 * the preceding statement to round each of the numbers to the nearest integer. For each number processed, display both 
 * the original number and the rounded number.
 */ 
namespace CHP07PE09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be rounded: ");
            FloorMe(Convert.ToDouble(Console.ReadLine()));
        }

        public static void FloorMe(double number)
        {
            Console.WriteLine("The original number is: {0}.", number);
            Console.WriteLine("The number after it got floored: {0}.", Math.Floor(number));
        }
    }
}
