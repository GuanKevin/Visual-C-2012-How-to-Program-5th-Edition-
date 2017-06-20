using System;

/**
 * 5.30 (Palindromes) 
 * A palindrome is a sequence of characters that reads the same backward as forward. For example, each of the following 
 * five-digit integers is a palindrome: 12321, 55555, 45554 and 11611. Write an app that reads in a five-digit integer 
 * and determines whether it’s a palindrome. If the number is not five digits long, display an error message and allow 
 * the user  to enter a new value. 
 * [Hint: Use the remainder and division operators to pick off the number’s digits one at a time, from right to left.]
 */ 
namespace CHP05PE30
{
    class Program
    {
        static void Main(string[] args)
        {
            int palindrome;

            Console.Write("Enter a 5 digit integer: ");
            palindrome = Convert.ToInt32(Console.ReadLine());

            while ((palindrome / 10000) == 0 || (palindrome / 10000) > 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR, INPUT IS NOT 5 DIGITS!" +
                    "\n!Enter a 5 digit integer: ");
                palindrome = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
            }

            if ((palindrome / 10000) == (palindrome % 10))
            {
                if ((((palindrome - ((palindrome / 10000) * 10000))) / 1000) == (((palindrome - (palindrome % 10)) % 100) / 10))
                {
                    Console.WriteLine("{0} is a palindrome!", palindrome);
                }
                else
                {
                    Console.WriteLine("{0} is not a palindrome!", palindrome);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome!", palindrome);
            }
        }
    }
}
