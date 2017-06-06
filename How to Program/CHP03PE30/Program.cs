using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int pNum = 0, 
                nNum = 0, 
                zero = 0;
            int num1,
                num2,
                num3,
                num4,
                num5;
            Console.Write("Enter 5 numbers: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            num3 = Convert.ToInt16(Console.ReadLine());
            num4 = Convert.ToInt16(Console.ReadLine());
            num5 = Convert.ToInt16(Console.ReadLine());

            if (num1 > 0)
                pNum += 1;
            else if (num1 < 0)
                nNum += 1;
            else
                zero += 1;

            if (num2 > 0)
                pNum += 1;
            else if (num2 < 0)
                nNum += 1;
            else
                zero += 1;

            if (num3 > 0)
                pNum += 1;
            else if (num3 < 0)
                nNum += 1;
            else
                zero += 1;

            if (num4 > 0)
                pNum += 1;
            else if (num4 < 0)
                nNum += 1;
            else
                zero += 1;

            if (num5 > 0)
                pNum += 1;
            else if (num5 < 0)
                nNum += 1;
            else
                zero += 1;

            Console.WriteLine("There are {0} positive numbers, {1} negative numbers and {2} zero(es)", pNum, nNum, zero);
        }
    }
}
