using System;

/**
 * 7.8 (Parking Charges) 
 * A parking garage charges a $2.00 minimum fee to park for up to three hours. The garage charges an additional $0.50 per 
 * hour for each hour or part thereof in excess of three hours. The maximum charge for any given 24-hour period is $10.00. 
 * Assume that no car parks for longer than 24 hours at a time. Write an app that calculates and displays the parking 
 * charges for each customer who parked in the garage yesterday. You should enter the hours parked for each customer. The 
 * app should display the charge for the current customer and should calculate and display the running total of 
 * yesterday’s receipts. The app should use method CalculateCharges to determine the charge for each customer.
 */ 
namespace CHP07PE08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateCharges(3.5));
        }

        public static decimal CalculateCharges(double hour)
        {
            if (hour <= 3)
                return 2M;
            else if (hour >= 24)
                return 10M;
            else
            {
                return 2M + (decimal) Math.Ceiling((hour - 3.0)) / 2;
            }
        }
    }
    
}
