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
            Console.Write("Enter side A: ");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side B: ");
            int sideB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side C: ");
            int sideC = Convert.ToInt32(Console.ReadLine());

            int productC = (int) Math.Pow(sideC, 2);
            int productAB = (int)(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            if (productAB == productC)
                Console.WriteLine("This is a right triangle!");
            else
                Console.WriteLine("This is not a right triangle!");
        }
    }
}
