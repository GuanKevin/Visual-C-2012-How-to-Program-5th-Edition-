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
            Console.WriteLine("Before rounding: 1.05.");
            Console.WriteLine("After rounding: {0}.", Math.Round(1.05));
        }
    }
}
