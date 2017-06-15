using System;

/**
 * 5.33 (Multiples of 2) 
 * Write an app that keeps displaying in the console window the powers of the integer 2—namely, 2, 4, 8, 16, 32, 64 
 * and so on. Loop 40 times. What happens when you run this app?
 */ 
namespace CHP05PE33
{
    class Program
    {
        static void Main(string[] args)
        {
            int multipleOfTwo = 2;
            int counter = 40;

            while (counter-- != 0)
            {
                Console.WriteLine(multipleOfTwo);
                multipleOfTwo *= 2;
            }
        }
    }
}
