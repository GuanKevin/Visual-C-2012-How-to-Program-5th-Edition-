using System;

/**
 * 6.27 (Structured Equivalent of continue Statement) 
 * Describe in general how you would remove any continue statement from a loop in an app and replace it with some 
 * structured equivalent. Use the technique you develop here to remove the continue statement from the app in Fig. 6.13.
 */ 
namespace CHP06PE27
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count <= 10; ++count)
            {
                if (count != 5)
                    Console.Write("{0} ", count);
            }

            Console.WriteLine("\nUsed continue to skip display 5");
        }
    }
}
