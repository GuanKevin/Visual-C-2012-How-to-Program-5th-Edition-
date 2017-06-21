using System;

/**
 * 7.20 (Circle Area) 
 * Write an app that prompts the user for the radius of a circle and uses method CircleArea to calculate the area of 
 * the circle.
 */ 
namespace CHP07PE20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of {0} is {1:N2}.", radius, CircleArea(radius));
        }

        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
