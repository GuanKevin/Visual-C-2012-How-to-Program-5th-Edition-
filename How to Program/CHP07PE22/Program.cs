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
            Console.Write("Enter C to calculate for celcius." +
                "\nEnter F to calculate for fahrenheit." +
                "\nCalculate for: ");
            char conversion = char.ToLower(Convert.ToChar(Console.Read()));
            Console.ReadLine();

            if (conversion == 'c')
            {
                Console.Write("Enter the temperature: ");
                double temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0} in celcius to fahrenheit is {1:N2}.", temperature, CelsiusToFahrenheit(temperature));
            }
            else if (conversion == 'f')
            {
                Console.Write("Enter the temperature: ");
                double temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0} in fahrenheit to celcius is {1:N2}.", temperature, FahrenheitToCelcius(temperature));
            }
            else
            {
                Console.WriteLine("Invalid character entered!");
            }
        }

        public static double CelsiusToFahrenheit(double celcius)
        {
            return 9.0 / 5.0 * celcius + 32;
        }

        public static double FahrenheitToCelcius(double fahrenheit)
        {
            return 5.0 / 9.0 * (fahrenheit - 32);
        }
    }
}
