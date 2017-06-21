using System;

/**
 * 6.17 (Calculating Sales) 
 * A website sells three products whose retail prices are as follows: 
 * product 1, $2.98; 
 * product 2, $4.50; and 
 * product 3, $9.98. 
 * Write an app that reads a series of pairs of numbers as follows:
 * a) product number
 * b) quantity sold
 * Your app should use a switch statement to determine the retail price for each product. It should calculate and display 
 * the total retail value of all products sold. Use a sentinel-controlled loop to determine when the app should stop 
 * looping and display the final results.
 */ 
namespace CHP06PE17
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sales = 0;
            int productNumber;
            Boolean breakout = false;

            Console.Write("Enter product number 1-3 (Any other to break): ");
            productNumber = Convert.ToInt32(Console.ReadLine());

            while (!breakout)
            {
                switch (productNumber)
                {
                    case 1:
                        Console.Write("Enter number sold: ");
                        sales += (2.98M * Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Enter number sold: ");
                        sales += (4.5M * Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Enter number sold: ");
                        sales += (9.98M * Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("Invalid input, ending program!");
                        breakout = true;
                        break;
                }

                if (!breakout)
                {
                    Console.Write("Enter product number 1-3 (Any other to break): ");
                    productNumber = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The total sales was {0:C}.", sales);
        }
    }
}
