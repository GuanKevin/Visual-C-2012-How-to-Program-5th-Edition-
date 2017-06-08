using System;

/*
 * 3.32 (Car-Pool Savings Calculator) 
 * Research several car-pooling websites. Create an app that calculates your daily driving cost, so that you can 
 * estimate how much money could be saved by car pooling, which also has other advantages such as reducing carbon 
 * emissions and reducing traffic congestion. The app should input the following information and display the user’s 
 * cost per day of driving to work: 
 * a) Total miles driven per day.
 * b) Cost per gallon of gasoline (in cents).
 * c) Average miles per gallon.
 * d) Parking fees per day (in cents).
 * e) Tolls per day (in cents).
 */
namespace CHP03PE32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total miles driven per day: ");
            int totalMilesPerDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the cost per gallon of gasoline (in cents): ");
            int costPerGallon = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the average miles per gallon: ");
            int averageMilesPerGallon = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the parking fees per day (in cents): ");
            int parkingFee = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the tolls per day (in cents): ");
            int tollsPerDay = Convert.ToInt32(Console.ReadLine());

            int totalCost = (((costPerGallon * (totalMilesPerDay / averageMilesPerGallon)) / 100) + parkingFee + tollsPerDay) / 100;
            Console.WriteLine("Total cost per day is {0}.", totalCost);
        }
    }
}
