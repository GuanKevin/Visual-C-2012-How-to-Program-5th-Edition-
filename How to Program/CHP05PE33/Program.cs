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
            int counter = 1;
            double product = 1;

            Console.WriteLine("Number\t\t\tPower");

            while (counter <= 40)
            {
                product *= 2;
                Console.WriteLine("{0}{1,20}", counter++, product);
            }
        }
    }
}
