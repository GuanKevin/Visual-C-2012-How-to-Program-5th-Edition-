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
            Console.Write("Enter hours parked: ");
            decimal hoursParked = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Parking for {0} hours will cost {1:C}.", hoursParked, CalculateCharges(hoursParked));
        }

        public static decimal CalculateCharges(decimal hoursParked)
        {
            if (hoursParked <= 3)
                return 2M;
            else if (hoursParked >= 24)
                return 10M;
            else
            {
                hoursParked -= 3;
                hoursParked = Math.Ceiling(hoursParked);
                return 2M + (hoursParked / 2);
            }
        }
    }
    
}
