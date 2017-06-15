using System;

/**
 * 5.38 (Infinite Series: Mathematical Constant e) 
 * Write an app that estimates the value of the mathematical constant e by using the formula The predefined constant 
 * Math.E (class Math is in the System namespace) provides a good approximation of e. Use the WriteLine method to 
 * output both your estimated value of e and Math.E for comparison.
 */ 
namespace CHP05PE38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double e = 1;
            int counter = 1;
            
            while (counter != number)
            {
                int counter2 = counter++;
                int sum = 1;
                while(counter2 != 0)
                {
                    sum *= counter2--;
                    if (counter2 == 0)
                        e += (1.0 / sum);
                }

                if (counter == number)
                    Console.WriteLine("My approximation of E is {0}.", e);
            }

            Console.WriteLine("Math.E approximation is {0}.", Math.E);
        }
    }
}
