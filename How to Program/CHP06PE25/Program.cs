using System;

/**
 * 6.25 (Structured Equivalent of break Statement) 
 * A criticism of the break statement and the continue statement (in a loop) is that each is unstructured. Actually, 
 * break and continue statements can always be replaced by structured statements, although doing so can be awkward. 
 * Describe in general how you would remove any break statement from a loop in an app and replace it with a structured 
 * equivalent. [Hint: The break statement exits a loop from the body of the loop. The other way to exit is by failing the 
 * loop-continuation test. Consider using in the loop-continuation test a second test that indicates “early exit because 
 * of a ‘break’ condition.”] Use the technique you develop here to remove the break statement from the app in Fig. 6.12.
 */ 
namespace CHP06PE25
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            for (count = 1; count <= 4; ++count)
            {
                Console.Write("{0} ", count);
            }
            Console.WriteLine("Broke out of loop when it ended!");
        }
    }
}
