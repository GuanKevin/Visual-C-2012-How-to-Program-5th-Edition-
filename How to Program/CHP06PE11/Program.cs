using System;

/**
 * 6.11 (Find the Smallest Value) 
 * Write an app that finds the smallest of several integers. Assume that the first value read specifies the number of 
 * values to input from the user.
 */
namespace CHP06PE11
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = Convert.ToInt32(Console.ReadLine());
            int smallestNumber = Convert.ToInt32(Console.ReadLine());
            int temp;

            for (int i = 1; i < counter; i++)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                if (temp < smallestNumber)
                    smallestNumber = temp;
            }

            Console.WriteLine("The smallest number entered is {0}.", smallestNumber);
        }
    }
}
