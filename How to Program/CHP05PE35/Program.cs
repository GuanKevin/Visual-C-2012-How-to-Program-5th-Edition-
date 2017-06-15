using System;

/**
 * 5.35 (Sides of a Triangle) 
 * Write an app that reads three nonzero values entered by the user, then determines and displays whether they 
 * could represent the sides of a triangle.
 */ 
namespace CHP05PE35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3 nonzero values: ");
            int side1 = Convert.ToInt32(Console.ReadLine()),
                side2 = Convert.ToInt32(Console.ReadLine()),
                side3 = Convert.ToInt32(Console.ReadLine());

            if ((side1 + side2) > side3)
            {
                if ((side1 + side3) > side2)
                {
                    if ((side2 + side3) > side1)
                    {
                        Console.WriteLine("The sides are valid!");
                    }
                    else
                    {
                        Console.WriteLine("The sides are not valid!");
                    }
                }
                else
                {
                    Console.WriteLine("The sides are not valid!");
                }
            }
            else
            {
                Console.WriteLine("The sides are not valid!");
            }
        }
    }
}
