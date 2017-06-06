using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 3.32 (Car-Pool Savings Calculator) 
 * Research several car-pooling websites. Create an app that calculates your daily driving cost, 
 * so that you can estimate how much money could be saved by car pooling, which also has other advantages 
 * such as reducing carbon emissions and reducing traffic congestion. The app should input the following information 
 * and display the user’s cost per day of driving to work: 
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
            int milesDrivenPerDay,
                costPerGal,
                averageMilesPerGal,
                parkingFee,
                tollsPerDay,
                totalCost,
                numOfCarPoolers;

            Console.Write("Enter miles driven per day: ");
            milesDrivenPerDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter cost per gallon (in cents): ");
            costPerGal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter average miles per gallon: ");
            averageMilesPerGal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter parking fee (in cents): ");
            parkingFee = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter tolls per day (in cents): ");
            tollsPerDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of carpoolers: ");
            numOfCarPoolers = Convert.ToInt16(Console.ReadLine());

            totalCost = ((costPerGal * (milesDrivenPerDay / averageMilesPerGal) / 100) + tollsPerDay + parkingFee) / 100;

            Console.WriteLine("It cost you ${0} a day!\nWith {1} carpoolers, it will cost ${2}.", totalCost, numOfCarPoolers, (totalCost / (numOfCarPoolers + 1)));

        }
    }
}
