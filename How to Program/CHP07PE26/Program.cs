using System;

/**
 * 7.26 (Reversing Digits)
 * Write a method that takes an integer value and returns the number with its digits reversed. For example, given the 
 * number 7631, the method should return 1367. Incorporate the method into an app that reads a value from the user and 
 * displays the result.
 */ 
namespace CHP07PE26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            Console.Write("The reverse of {0} is ", digit);
            ReverseDigit(digit);
        }

        public static void ReverseDigit(int digit)
        {
            while (digit != 0)
            {
                Console.Write(digit % 10);
                digit = digit / 10;
            }
            Console.WriteLine();
        }
    }
}
