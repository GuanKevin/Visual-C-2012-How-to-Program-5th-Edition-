using System;

/**
 * 5.27 (Dangling-else Problem) 
 * Determine the output for each of the given sets of code when x is 9 and y is 11 and when x is 11 and y is 9. 
 * The compiler ignores the indentation in aC# app. Also, the C# compiler always associates an else with the immediately 
 * preceding if unless told to do otherwise by the placement of braces ({}). On first glance, you may not be sure 
 * which if an else matches—this situation is referred to as the “dangling-else problem.”We’ve eliminated the 
 * indentation from the following code to make the problemmore challenging. [Hint: Apply the indentation conventions 
 * you’ve learned.]
 */ 
namespace CHP05PE27
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             a) if ( x < 10 )
            if ( y > 10 )
            Console.WriteLine( "*****" );
            else
            Console.WriteLine( "#####" );
            Console.WriteLine( "$$$$$" );
            b) if ( x < 10 )
            {
            if ( y > 10 )
            Console.WriteLine( "*****" );
            }
            else
            {
            Console.WriteLine( "#####" );
            Console.WriteLine( "$$$$$" );
            }
            */
        }
    }
}
