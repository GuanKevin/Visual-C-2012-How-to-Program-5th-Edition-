using System;

/**
 * 5.31 (Displaying the Decimal Equivalent of a Binary Number) 
 * Write an app that inputs an integer containing only 0s and 1s (i.e., a binary integer) and displays its decimal 
 * equivalent. [Hint: Picking the digits off a binary number is similar to picking the digits off a decimal number, 
 * which you did in Exercise 5.30. In the decimal number system, the rightmost digit has a positional value of 1 and 
 * the next digit to the left has a positional value of 10, then 100, then 1000 and so on. The decimal number 234 can 
 * be interpreted as 4 * 1 + 3 * 10 + 2 * 100. In the binary number system, the rightmost digit has a positional value 
 * of 1, the next digit to the left has a positional value of 2, then 4, then 8 and so on. The decimal equivalent of 
 * binary 1101 is 1 * 1 + 0 * 2 + 1 * 4 + 1 * 8, or 1 + 0 + 4 + 8, or 13.]
 */ 
namespace CHP05PE31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            int binary = Convert.ToInt32(Console.ReadLine()),
                value = 1,
                decimalValue = 0;

            while (binary != 0)
            {
                decimalValue += (binary % 10) * value;
                value *= 2;
                binary = (binary - (binary % 10)) / 10;
            }

            Console.WriteLine("The decimal value is {0}.", decimalValue);
        }
    }
}
