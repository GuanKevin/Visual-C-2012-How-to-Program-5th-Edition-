using System;

/**
 * 5.17 (GasMileage) 
 * Drivers are concerned with the mileage their automobiles get. One driver has kept track of several tankfuls of gasoline 
 * by recording the miles driven and gallons used for each tankful. Develop a C# app that will input the miles driven and 
 * gallons used (both as integers) for each tankful. The app should calculate and display the miles per gallon obtained 
 * for each tankful and display the combined miles per gallon obtained for all tankfuls up to this point. All averaging 
 * calculations should produce floating-point results. Display the results rounded to the nearest hundredth. Use the 
 * Console class’s ReadLine method and sentinel-controlled repetition to obtain the data from the user.
 */
namespace CHP05PE17
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = 0,
                gallons = 0,
                input = 1;
        
            while (input == 1)
            {
                Console.Write("Enter the miles: ");
                miles += Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the gallons: ");
                gallons += Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a 1 to continue, else any other number to end: ");
                input = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Miles: {0}" +
                "\nGallons: {1}" +
                "\nMPG: {2:N2}", miles, gallons, ((double) miles / gallons));
        }
    }
}
