using System;

/**
 * 4.15 (Target-Heart-Rate Calculator) 
 * While exercising, you can use a heart-rate monitor to see that your heart rate stays within a safe range 
 * suggested by your trainers and doctors. According to the American Heart Association (AHA),
 * the formula for calculating your maximum heart rate in beats per minute is 220 minus your age in years. 
 * Your target heart rate is a range that is 50–85% of your maximum heart rate.
 * Create a class called HeartRates. The class attributes should include the person’s first name, last name, year 
 * of birth and the current year. Your class should have a constructor that receives this data as parameters. 
 * For each attribute provide a property with set and get accessors. The class also should include a property 
 * that calculates and returns the person’s age (in years), a property that calculates and returns the person’s 
 * maximum heart rate and properties that calculate and return the person’s minimum and maximim target heart rates. 
 * Write an app that prompts for the person’s information, instantiates an object of class HeartRates and displays 
 * the information from that object—including the person’s first name, last name and year of birth—then calculates 
 * and displays the person’s age in (years), maximum heart rate and target-heart-rate range.
 */
namespace CHP04PE15
{
    class Program
    {
        static void Main(string[] args)
        {
            HeartRates me = new HeartRates();
            Console.WriteLine("Mininum heart rate during exercise should be {0}.", me.MinimumHeartRate());
            Console.WriteLine("Maximum heart rate during exercise should be {0}.", me.MaximumHeartRate());
        }
    }   
}
