using System;

/**
 * 6.22 (Modified Triangle Program) 
 * Modify Exercise 6.15 to combine your code from the four separate triangles of asterisks such that all four patterns 
 * display side by side. Make clever use of nested for loops.
 */ 
namespace CHP06PE22
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("* ");

                for (int k = 0 + i; k < 10; k++)
                    Console.Write("  ");

                for (int l = 10; l > i; l--)
                    Console.Write("* ");

                for (int m = 0; m <= i; m++)
                    Console.Write("    ");

                for (int n = 10; n > i; n--)
                    Console.Write("* ");

                for (int o = 10; o > i; o--)
                    Console.Write("  ");

                for (int p = 0; p <= i; p++)
                    Console.Write("* ");

                Console.WriteLine();
            }
        }
    }
}
