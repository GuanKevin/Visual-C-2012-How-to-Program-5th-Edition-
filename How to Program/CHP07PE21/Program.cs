using System;

/**
 * 7.21 (Separating Digits) 
 * Write code segments that accomplish each of the following tasks:
 * a) Calculate the integer part of the quotient when integer a is divided by integer b.
 * b) Calculate the integer remainder when integer a is divided by integer b.
 * c) Use the app pieces developed in parts (a) and (b) to write a method DisplayDigits that
 * receives an integer between 1 and 99999 and displays it as a sequence of digits, separating each pair of digits by 
 * two spaces. For example, the integer 4562 should appear as: 4 5 6 2.
 * d) Incorporate the method developed in part (c) into an app that inputs an integer and calls DisplayDigits by passing 
 * the method the integer entered. Display the results.
 */ 
namespace CHP07PE21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Turning {0} to: {1}", number, DisplayDigits(number));
        }

        public static String DisplayDigits(int number)
        {
            String digits = "";

            while (number > 0)
            {
                digits = (FindRemainder(number, 10) + " " + digits);
                number = FindQuotient(number, 10);
            }

            return digits;
        }

        public static int FindRemainder(int number1, int number2)
        {
            return (number1 % number2);
        }

        public static int FindQuotient(int number1, int number2)
        {
            return (number1 / number2);
        }
    }
}
