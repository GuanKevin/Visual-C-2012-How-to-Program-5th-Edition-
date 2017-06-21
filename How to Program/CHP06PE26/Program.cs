using System;

/**
 * 6.26 (What Does This Code Do?) 
 * What does the following code segment do?
 */ 
namespace CHP06PE26
{
    class Program
    {
        static void Main(string[] args)
        {             
            for ( int i = 1; i <= 5; ++i )
            {
                for ( int j = 1; j <= 3; ++j )
                {
                    for ( int k = 1; k <= 4; ++k )
                        Console.Write( '*' );
                    Console.WriteLine();
                } 
                Console.WriteLine();
            }             
        }
    }
}
