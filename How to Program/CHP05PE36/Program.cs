using System;

/**
 * 5.36 (Sides of a Right Triangle) 
 * Write an app that reads three nonzero integers, then determines 
 * and displays whether they could represent the sides of a right triangle.
 */ 
namespace CHP05PE36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3 nonzero values: ");
            int side1 = Convert.ToInt32(Console.ReadLine()),
                side2 = Convert.ToInt32(Console.ReadLine()),
                side3 = Convert.ToInt32(Console.ReadLine());

            if ((Math.Pow(side1, 2) + Math.Pow(side2, 2)) == Math.Pow(side3, 2))
                Console.WriteLine("This is a right triangle!");
            else
                Console.WriteLine("This is not a right triangle!");
        }
    }
}
