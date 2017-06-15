using System;

/**
 * 6.23 (Displaying a Diamond) 
 * Write an app that displays the following diamond shape. You may use output statements that display a single asterisk 
 * (*), a single space or a single newline character. Maximize your use of repetition (with nested for statements) and 
 * minimize the number of output statements.
 */
namespace CHP06PE23
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 4; j++)
                    Console.Write(" ");

                for (int k = 0; k <= i; k++)
                    Console.Write("*");

                for (int l = 1; l <= i; l++)
                    Console.Write("*");

                Console.WriteLine();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(" ");

                for (int k = 4; k > i; k--)
                    Console.Write("*");

                for (int l = 3; l > i; l--)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
