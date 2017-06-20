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
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (Multiple(number1, number2))
                Console.WriteLine("{0} is a multiple of {1}!", number2, number1);
            else
                Console.WriteLine("{0} is not a multiple of {1}!", number2, number1);
        }

        public static Boolean Multiple(int number1, int number2)
        {
            if ((number1 % number2) == 0)
                return true;
            else
                return false;
        }
    }
}
