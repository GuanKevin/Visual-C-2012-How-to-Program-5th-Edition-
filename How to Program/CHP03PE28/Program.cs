using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * (Digits of an Integer) 
 * Write an app that inputs one number consisting of five digits from the user, separates the number into its individual digits 
 * and displays the digits separated from one another by three spaces each. For example, if the user types in the number 42339, 
 * the app should display 
 * 4   2   3   3   9
 * Assume that the user enters the correct number of digits. What happens when you execute the app and type a number with more than 
 * five digits? What happens when you execute the app and type a number with fewer than five digits? 
 * [Hint: It’s possible to do this exercise with the techniques you learned in this chapter. 
 * You’ll need to use both division and remainder operations to “pick off ” each digit.]
 */
namespace CHP03PE28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int digit1,
                digit2,
                digit3,
                digit4,
                digit5;

            if ((number / 10000) == 0)
                Console.WriteLine("Number is less than 5 digits!");
            else if ((number / 10000) > 9)
                Console.WriteLine("Number is greater than 5 digits!");
            else
            {
                digit1 = number / 10000;
                number %= 10000;
                digit2 = number / 1000;
                number %= 1000;
                digit3 = number / 100;
                number %= 100;
                digit4 = number / 10;
                number %= 10;
                digit5 = number;
                String space3 = "   ";
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{4}{1}{5}", digit1, space3, digit2, digit3, digit4, digit5);
            }
        }
    }
}
