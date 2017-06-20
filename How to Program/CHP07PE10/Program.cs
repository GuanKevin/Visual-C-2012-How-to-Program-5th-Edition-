using System;

/**
 * 7.10 (Rounding to a Specific Decimal Place) 
 * Math.Floor may be used to round a number to a specific decimal place. The statement 
 * y = Math.Floor( x * 10 + 0.5 ) / 10;
 * rounds x to the tenths position (i.e., the first position to the right of the decimal point). The statement 
 * y = Math.Floor( x * 100 + 0.5 ) / 100;
 * rounds x to the hundredths position (i.e., the second position to the right of the decimal point). 
 * Write an app that defines four methods for rounding a number x in various ways:
 * a) RoundToInteger( number ) 
 * b) RoundToTenths( number ) 
 * c) RoundToHundredths( number )
 * d) RoundToThousandths( number )
 * For each value read, your app should display the original value, the number rounded to the nearest integer, the number 
 * rounded to the nearest tenth, the number rounded to the nearest hundredth and the number rounded to the nearest thousandth.
 */ 
namespace CHP07PE10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RoundToThousandths(54.1567));
        }

        public static double RoundToThousandths(double number)
        {
            return Math.Floor(number * 1000 + 0.5) / 1000;
        }

        public static double RoundToHundredths(double number)
        {
            return Math.Floor(number * 100 + 0.5) / 100;
        }

        public static double RoundToTenths(double number)
        {
            return Math.Floor(number * 10 + 0.5) / 10;
        }

        public static int RoundToInteger(double number)
        {
            return (int) number;
        }
    }
}
