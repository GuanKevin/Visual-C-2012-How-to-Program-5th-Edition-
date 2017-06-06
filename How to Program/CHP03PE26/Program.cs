using System;

/**
 * 3.26 (Diameter, Circumference and Area of a Circle) 
 * Write an app that inputs from the user the radius of a circle as an integer and displays the circle’s diameter, 
 * circumference and area using the floating-point value 3.14159 for π. 
 * [Note: You may also use the predefined constant Math.PI for the value of π. This constant is more precise than the 
 * value 3.14159. Class Math is defined in namespace System]. Use the following formulas (r is the radius):
 * diameter = 2 * r 
 * circumference = 2 * π * r
 * area = π * r^2
 * Don’t store each calculation’s result in a variable. Rather, specify each calculation as the value to be output in a 
 * Console.WriteLine statement. The values produced by the circumference and area calculations are floating-point numbers.
 */
namespace CHP03PE26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The radius is {0}.", radius);
            Console.WriteLine("The diameter is {0}.", (2 * radius));
            Console.WriteLine("The circumference is {0}.", (2 * Math.PI * radius));
            Console.WriteLine("The area is {0}.", (Math.PI * Math.Pow(radius, 2)));
        }
    }
}
