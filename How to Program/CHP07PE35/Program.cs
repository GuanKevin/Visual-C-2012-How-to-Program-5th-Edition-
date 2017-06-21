using System;

/**
 * 7.35 (Recursive Power Calculation) 
 * Write recursive method Power(base, exponent) that, when called, returns base exponent For example, 
 * Power(3, 4) = 3 * 3 * 3 * 3. Assume that exponent is an integer greater than or equal] to 1. The recursion step 
 * should use the relationship base exponent = base · base exponent – 1 The terminating condition occurs when exponent 
 * is equal to 1, because base1 = base Incorporate this method into an app that enables the user to enter the base and 
 * exponent.
 */ 
namespace CHP07PE35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doing recursion: {0}", Power(4, 3));
        }

        public static double Power(int baseNum, int exponent)
        {
            if (exponent == 1)
                return baseNum;

            return baseNum * Power(baseNum, exponent - 1);
        }
    }
}
