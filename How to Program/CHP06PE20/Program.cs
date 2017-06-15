using System;

/**
 * 6.20 (Calculating the Value of π) 
 * Calculate the value of π from the infinite series Display a table that shows the value of π approximated by computing 
 * one term of this series, by two terms, by three terms, and so on. How many terms of this series do you have to use 
 * before you first get 3.14? 3.141? 3.1415? 3.14159?
 */  
namespace CHP06PE20
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 4;
            Boolean operation = true;
            for (int i = 3; i <= 1000; i += 2)
            {
                if (operation)
                {
                    pi -= (4.0 / i);
                }
                else
                {
                    pi += (4.0 / i);
                }
                
                operation = !operation;
                Console.WriteLine("{0} ", pi);

                if (pi >= 3.14 && pi < 3.15)
                {
                    Console.WriteLine("First iteration of 3.14 is reached at 4/{0}.", i);
                    break;
                }
            }
        }
    }
}
