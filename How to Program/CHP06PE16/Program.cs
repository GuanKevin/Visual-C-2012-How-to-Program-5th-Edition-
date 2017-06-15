using System;

/**
 * 6.16 (Displaying a Bar Chart) 
 * One interesting application of computers is to display graphs and bar charts. Write an app that reads three numbers 
 * between 1 and 30. For each number that’s read, your app should display the same number of adjacent asterisks. For 
 * example, if your app reads the number 7, it should display *******.
 */ 
namespace CHP06PE16
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                int length = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < length; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
