using System;

/**
 * 7.18 (Displaying a Square of Asterisks) 
 * Write method SquareOfAsterisks that displays a solid square (the same number of rows and columns) of asterisks whose side 
 * length is specified in integer parameter side. For example, if side is 4, the method should display
 * ****
 * ****
 * ****
 * ****
 */
namespace CHP07PE18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            SquareOfAsterisks(Convert.ToInt32(Console.ReadLine()));
        }

        public static void SquareOfAsterisks(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}
