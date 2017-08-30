using System;

/**
 * 10.03 (Rectangle Class) Create class Rectangle. The class has attributes length and width, each of which defaults to 1. 
 * It has read-only properties that calculate the Perimeter and the Area of the rectangle. It has properties for both length and width. 
 * The set accessors should verify that length and width are each floating-point numbers greater than 0.0 and less than 20.0.
 * Write an app to test class Rectangle. 
 */
namespace CHP10PE03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Test 1: Testing for no parameter constructor
                Rectangle rec1 = new Rectangle();
                Console.WriteLine("Empty Parameters\n" + rec1.ToString());

                rec1.Length = 2;
                rec1.Width = 3;

                // Test 2: Pass a rectangle object
                Rectangle rec2 = new Rectangle(rec1);

                Console.WriteLine("\nSet Width, Set Length\n" + rec2.ToString());
            } catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine("Something went wrong with testing with no parameter constructor!"
                    + aore.ToString());
            }
            
        }
    }
}
