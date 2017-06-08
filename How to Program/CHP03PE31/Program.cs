using System;

/**
 * 3.31 (Body Mass Index Calculator) 
 * We introduced the body mass index (BMI) calculator in Exercise 1.29. The formulas for calculating the BMI are
 * BMI = (weightInPounds x 703) / (heightInInches x heightInInches)
 * BMI = (weightInKilograms) / (heightInMeters x heightInMeters)
 * Create a BMI calculator app that reads the user’s weight in pounds and height in inches 
 * (or, if you prefer, the user’s weight in kilograms and height in meters), then calculates and displays the user’s 
 * body mass index. The app should also display the following information from the Department of Health and Human 
 * Services/National Institutes of Health so the user can evaluate his/her BMI:
 * Underweight: less than 18.5
 * Normal: between 18.5 and 24.9 
 * Overweight: between 25 and 29.9
 * Obese: 30 or greater
 */
namespace CHP03PE31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight in pound: ");
            int weightInPounds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height in inches: ");
            int heightInInches = Convert.ToInt32(Console.ReadLine());
            int bmi = (int) ((weightInPounds * 703) / (Math.Pow(heightInInches, 2)));

            Console.WriteLine("\nBMI range:" +
                "\nUnderweight: less than 18.5" +
                "\nNormal: between 18.5 and 24.9" +
                "\nOverweight: between 25 and 29.9" +
                "\nObese: 30 or greater");

            Console.WriteLine("Your bmi is {0}.", bmi);
        }
    }
}
