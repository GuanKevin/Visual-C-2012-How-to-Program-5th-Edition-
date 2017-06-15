using System;

/**
 * 6.15 (Displaying Triangles) 
 * Write an app that displays the following patterns separately, one below the other. Use for loops to generate the 
 * patterns. All asterisks (*) should be displayed by a single statement of the form Console.Write( '*' ); which causes 
 * the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next 
 * line. A statement of the form Console.Write( ' ' ); can be used to display a space for the last two patterns. There 
 * should be no other output statements in the app. [Hint: The last two patterns require that each line begin with an 
 * appropriate number of blank spaces.]
 */ 
namespace CHP06PE15
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 10; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 10; k >= i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int k = 10; k > i; k--)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
