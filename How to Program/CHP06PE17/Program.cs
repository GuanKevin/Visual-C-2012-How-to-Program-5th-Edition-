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
            int productNumber;
            decimal productOneRetailPrice = 0,
                productTwoRetailPrice = 0,
                productThreeRetailPrice = 0;


            Console.Write("Enter product number between 1 to 3 else it will terminate: ");
            productNumber = Convert.ToInt32(Console.ReadLine());

            while (productNumber >= 0 && productNumber <= 3)
            {
                switch (productNumber)
                {
                    case 1:
                        productOneRetailPrice += 2.98M;
                        break;
                    case 2:
                        productTwoRetailPrice += 4.5M;
                        break;
                    case 3:
                        productThreeRetailPrice += 9.98M;
                        break;
                    default:
                        break;
                }

                Console.Write("Enter another product number: ");
                productNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Product{0, 10}", "Sales");
            Console.WriteLine("1{0, 15:C}", productOneRetailPrice);
            Console.WriteLine("2{0, 15:C}", productTwoRetailPrice);
            Console.WriteLine("3{0, 15:C}", productThreeRetailPrice);
        }
    }
}
