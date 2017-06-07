using System;

/**
 * 3.29 (Table of Squares and Cubes) 
 * Using only the programming techniques you learned in this chapter, write an app that calculates the squares 
 * and cubes of the numbers from 0 to 10 and displays the resulting values in table format, as shown below. 
 * All calculations should be done in terms of a variable x. 
 * [Note: This app does not require any input from the user.]
 */
namespace CHP03PE29
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            // Pre-increment
            // Post-increment
            Console.WriteLine("Number    Square    Cube");
            Console.WriteLine("{0}{1}{2}{3}{4}", x, "         ", Math.Pow(x, 2), "         ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "         ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "         ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "         ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "        ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "        ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "        ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "        ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "        ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "         ", Math.Pow(x, 2), "        ", Math.Pow(x, 3));
            Console.WriteLine("{0}{1}{2}{3}{4}", ++x, "        ", Math.Pow(x, 2), "       ", Math.Pow(x, 3));
        }
    }
}
