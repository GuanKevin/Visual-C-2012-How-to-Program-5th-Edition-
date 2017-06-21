using System;

/**
 * 6.24 (Modified Diamond Program) 
 * Modify the app you wrote in Exercise 6.23 to read an odd number in the range 1 to 19 to specify the number of rows in 
 * the diamond. Your app should then display a diamond of the appropriate size.
 */ 
namespace CHP06PE24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 - 19: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if ((size % 2) == 0)
                Console.WriteLine("It is not an odd number!");
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = i; j < (size - 1); j++)
                        Console.Write(" ");

                    for (int k = 0; k <= i; k++)
                        Console.Write("*");

                    for (int l = 1; l <= i; l++)
                        Console.Write("*");

                    Console.WriteLine();
                }

                for (int i = 0; i < (size - 1); i++)
                {
                    for (int j = 0; j <= i; j++)
                        Console.Write(" ");

                    for (int k = (size - 1); k > i; k--)
                        Console.Write("*");

                    for (int l = (size - 2); l > i; l--)
                        Console.Write("*");

                    Console.WriteLine();
                }
            }
        }
    }
}
