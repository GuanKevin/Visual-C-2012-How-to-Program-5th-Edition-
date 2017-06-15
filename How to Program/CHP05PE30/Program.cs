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
            Boolean isFiveDigit = false;
            String digit;

            while (!isFiveDigit)
            {
                Console.Write("Enter a 5 digit integer: ");
                digit = Convert.ToString(Console.ReadLine());

                if (digit.Length == 5)
                {
                    palindrome = Convert.ToInt32(digit);
                    isFiveDigit = true;


                    if (palindrome / 10000 == palindrome % 10)
                    {
                        palindrome -= ((palindrome / 10000) * 10000);
                        palindrome -= (palindrome % 10);
                        palindrome /= 10;

                        if (palindrome / 100 == palindrome % 10)
                            Console.WriteLine("{0} is a palindrome.", digit);
                        else
                            Console.WriteLine("{0} is not a palindrome.", digit);
                    }
                    else
                        Console.WriteLine("{0} is not a palindrome.", digit);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: DIGIT ENTERED IS NOT 5 DIGIT!");
                    Console.ResetColor();
                }
            }       
        }
    }
}
