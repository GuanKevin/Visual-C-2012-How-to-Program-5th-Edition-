using System;

/**
 * 7.32 (Distance Between Two Points) 
 * Write method Distance to calculate the distance between two points (x1, y1) and (x2, y2). All numbers and return 
 * values should be of type double. Incorporate this method into an app that enables the user to enter the coordinates 
 * of the points.
 */ 
namespace CHP07PE32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The distance between the two points is: {0}.", Distance(x1, y1, x2, y2));
        }

        public static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2)) * ((y2 - y1) * (y2 - y1));
        }
    }
}
