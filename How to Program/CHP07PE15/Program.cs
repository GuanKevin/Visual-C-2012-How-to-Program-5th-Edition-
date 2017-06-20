using System;

/**
 * 7.15 (Hypotenuse of a Right Triangle) 
 * Write method Hypotenuse that calculates the length of the hypotenuse of a right triangle when the lengths of the other 
 * two sides are given. The method should take two arguments of type double and return the hypotenuse as a double. 
 * Incorporate this method into an app that reads values for side1 and side2 and performs the calculation with the 
 * Hypotenuse method. 
 */ 
namespace CHP07PE15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The hypotenuse is {0}.", TriangleHypotenuse(side1, side2));
        }

        public static double TriangleHypotenuse(double side1, double side2)
        {
            return Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
        }
    }
}
