using System;

/**
 * 5.32 (Checkerboard Pattern of Asterisks) 
 * Write an app that uses only the output statements
 * Console.Write( "* " );
 * Console.Write( " " );
 * Console.WriteLine();
 * to display the checkerboard pattern that follows. A Console.WriteLine method call with no arguments outputs a 
 * single newline character. [Hint: Repetition statements are required.]
 */ 
namespace CHP05PE32
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 8;
            
            while (counter-- != 0)
            {
                int counter2 = 8;
                if (counter % 2 == 0)
                    Console.Write(" ");

                while (counter2-- != 0)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
