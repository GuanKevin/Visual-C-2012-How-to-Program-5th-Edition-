using System;

/*
 * 3.31 (Body Mass Index Calculator) 
 * We introduced the body mass index (BMI) calculator in Exercise 1.29. The formulas for calculating the BMI are
 * BMI = (weightInPounds x 703) / (heightInInches x heightInInches)
 * BMI = (weightInKilograms) / (heightInMeters x heightInMeters)
 * Create a BMI calculator app that reads the user’s weight in pounds and height in inches 
 * (or, if you prefer, the user’s weight in kilograms and height in meters), then calculates and displays the user’s body mass index. 
 * The app should also display the following information from the Department of Health and Human Services/National Institutes of Health 
 * so the user can evaluate his/her BMI:
 * BMI VALUES
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
            int weightInPounds,
                heightInInches,
                bmi;

            Console.Write("Enter your weight in pounds: ");
            weightInPounds = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter your height in inches: ");
            heightInInches = Convert.ToInt16(Console.ReadLine());

            bmi = (weightInPounds * 703) / (heightInInches * heightInInches);

            if (bmi < 18.5)
                Console.WriteLine("Your bmi is {0}: underweight!", bmi);
            else if (bmi < 24.9)
                Console.WriteLine("Your bmi is {0}: normal!", bmi);
            else if (bmi < 29.9)
                Console.WriteLine("Your bmi is {0}: overweight!", bmi);
            else
                Console.WriteLine("Your bmi is {0}: obese!", bmi);
        }
    }
}
