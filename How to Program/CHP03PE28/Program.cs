using System;

/*
 * 3.28 (Digits of an Integer) 
 * Write an app that inputs one number consisting of five digits from the user, separates the number into its individual 
 * digits and displays the digits separated from one another by three spaces each. For example, if the user types in the 
 * number 42339, the app should display 4   2   3   3   9
 * Assume that the user enters the correct number of digits. What happens when you execute the app and type a number with 
 * more than five digits? What happens when you execute the app and type a number with fewer than five digits? 
 * [Hint: It’s possible to do this exercise with the techniques you learned in this chapter. 
 * You’ll need to use both division and remainder operations to “pick off” each digit.]
 */
namespace CHP03PE28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 5 digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You've entered {0}.", number);

            if (number / 10000 > 9)
                Console.WriteLine("{0} is greater than 5 digits!", number);
            else if (number / 10000 == 0)
                Console.WriteLine("{0} is less than 5 digits!", number);
            else
            {
                int digit1,
                    digit2,
                    digit3,
                    digit4,
                    digit5;

                digit1 = number / 10000;
                number = number % 10000;
                digit2 = number / 1000;
                number = number % 1000;
                digit3 = number / 100;
                number = number % 100;
                digit4 = number / 10;
                number = number % 10;
                digit5 = number;
                String space = "   ";

                Console.WriteLine("{1}{0}{2}{0}{3}{0}{4}{0}{5}", space, digit1, digit2, digit3, digit4, digit5);
            }
        }
    }
}
