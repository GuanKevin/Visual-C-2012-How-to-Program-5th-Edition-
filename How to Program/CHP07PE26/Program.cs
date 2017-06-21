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
            Console.WriteLine(ReverseDigit(0123450));
        }

        public static String ReverseDigit(int number)
        {
            String reversed = "";
            while (number != 0)
            {
                reversed += number % 10;
                number /= 10;
            }
            return (reversed);
        }
    }
}
