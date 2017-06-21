using System;

/**
 * 7.22 (Temperature Conversions) 
 * Implement the following integer methods:
 * a) Method Celsius returns the Celsius equivalent of a Fahrenheit temperature, using the calculation
 *      c = 5.0 / 9.0 * ( f - 32 );
 * b) Method Fahrenheit returns the Fahrenheit equivalent of a Celsius temperature, using the calculation 
 *      f = 9.0 / 5.0 * c + 32;
 * c) Use the methods from parts (a) and (b) to write an app that enables the user either to enter a Fahrenheit 
 * temperature and display the Celsius equivalent or to enter a Celsius temperature and display the Fahrenheit equivalent.
 */ 
namespace CHP07PE22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter c to convert Celius to Fahrenheit.");
            Console.WriteLine("Enter f to conver Fahrenheit to Celius.");
            Console.Write("Enter choice: ");
            char temp = char.ToLower(Convert.ToChar(Console.Read()));
            Console.ReadLine();

            switch (temp)
            {
                case 'c':
                    Console.Write("Enter the temperature in celcius: ");
                    Console.WriteLine("The temperature in fahrenheit after conversion is {0}.", 
                        CelciusToFahrenheit(Convert.ToDouble(Console.ReadLine())));
                    break;
                case 'f':
                    Console.Write("Enter the temperature in fahrenheit: ");
                    Console.WriteLine("The temperature in celcius after conversion is {0}.",
                        FahrenheitToCelcius(Convert.ToDouble(Console.ReadLine())));
                    break;
                default:
                    Console.WriteLine("Invalid character entered, ending program.");
                    break;
            }
        }

        public static double CelciusToFahrenheit(double c)
        {
            return (9.0 / 5.0) * c + 32;
        }

        public static double FahrenheitToCelcius(double f)
        {
            return (5.0 / 9.0) * (f - 32);
        }
    }
}
