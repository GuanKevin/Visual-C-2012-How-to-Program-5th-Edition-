using System;

/**
 * 3.30 (Counting Negative, Positive and Zero Values) 
 * Write an app that inputs five numbers 
 * and determines and displays the number of negative numbers input, 
 * the number of positive numbers input and the number of zeros input.
 */
namespace CHP03PE30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine()),
                num2 = Convert.ToInt32(Console.ReadLine()),
                num3 = Convert.ToInt32(Console.ReadLine()),
                num4 = Convert.ToInt32(Console.ReadLine()),
                num5 = Convert.ToInt32(Console.ReadLine()),
                posCounter = 0,
                negCounter = 0,
                zeroCounter = 0;

            if (num1 > 0)
                posCounter++;
            else if (num1 < 0)
                negCounter++;
            else
                zeroCounter++;

            if (num2 > 0)
                posCounter++;
            else if (num2 < 0)
                negCounter++;
            else
                zeroCounter++;

            if (num3 > 0)
                posCounter++;
            else if (num3 < 0)
                negCounter++;
            else
                zeroCounter++;

            if (num4 > 0)
                posCounter++;
            else if (num4 < 0)
                negCounter++;
            else
                zeroCounter++;

            if (num5 > 0)
                posCounter++;
            else if (num5 < 0)
                negCounter++;
            else
                zeroCounter++;

            Console.WriteLine("You have {0} postive number(s), {1} negative number(s) and {2} zero(es)!", posCounter, negCounter, zeroCounter);
        }
    }
}
