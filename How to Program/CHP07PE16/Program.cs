using System;

/**
 * 7.16 (Multiples) 
 * Write method Multiple that determines, for a pair of integers, whether the second integer is a multiple of the first. 
 * The method should take two integer arguments and return true if the second is a multiple of the first and false 
 * otherwise. Incorporate this method into an app that inputs a series of pairs of integers (one pair at a time) and 
 * determines whether the second value in each pair is a multiple of the first.
 */ 
namespace CHP07PE16
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Multiples(21, 7))
                Console.WriteLine("We got a multiple!");
            else
                Console.WriteLine("We don't have a multiple!");
        }

        public static Boolean Multiples(int num1, int num2)
        {
            if (num1 % num2 == 0)
                return true;
            else
                return false;
        }
    }
}
