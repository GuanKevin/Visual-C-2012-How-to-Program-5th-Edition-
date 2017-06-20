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
            Console.Write("Enter side A: ");
            int sideA = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter side B: ");
            int sideB = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter side C: ");
            int sideC = Convert.ToInt16(Console.ReadLine());

            if ((sideA + sideB) > sideC)            
                if ((sideA + sideC) > sideB)                
                    if ((sideB + sideC) > sideA)
                        Console.WriteLine("This is a valid triangle!");
                    else
                        Console.WriteLine("This is an invalid triangle!");                
                else
                    Console.WriteLine("This is an invalid triangle!");            
            else
                Console.WriteLine("This is an invalid triangle!");
        }
    }
}
