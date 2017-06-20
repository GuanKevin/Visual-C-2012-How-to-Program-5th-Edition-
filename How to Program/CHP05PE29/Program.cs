using System;

/**
 * 5.29 (Square of Asterisks) 
 * Write an app that prompts the user to enter the size of the side of a square, then displays a hollow square of that 
 * sizemade of asterisks. Your app should work for squares of all side lengths between 1 and 20. If the user enters a 
 * number less than 1 or greater than 20, your app should display a square of size 1 or 20, respectively.
 */ 
namespace CHP05PE29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the square: ");
            int square = Convert.ToInt32(Console.ReadLine());

            if (square < 1 || square > 20)
                square = 20;

            int counter = 0;
            while (counter++ < square)
            {
                int innerCounter = 0;
                while (innerCounter++ < square)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
