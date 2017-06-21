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
            Console.Write("Enter the number of values to input: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int smallestNum = int.MaxValue;


            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter number {0}: ", i);
                int tempNum = Convert.ToInt32(Console.ReadLine());

                if (smallestNum > tempNum)
                    smallestNum = tempNum;
            }

            Console.WriteLine("The smallest number is {0}.", smallestNum);
        }
    }
}
