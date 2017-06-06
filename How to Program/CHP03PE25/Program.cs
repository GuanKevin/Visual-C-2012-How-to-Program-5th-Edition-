using System;

/**
 * 3.25 (Multiples) 
 * Write an app that reads two integers, determines whether the first is a multiple of the second and displays the result. 
 * [Hint: Use the remainder operator.] 
 */
namespace CHP03PE25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The numbers entered are {0} and {1}.", num1, num2);

            if (num2 % num1 == 0)
                Console.WriteLine("{0} is a multiple of {1}.", num1, num2);
            else
                Console.WriteLine("{0} is not a multiple of {1}.", num1, num2);
        }
    }
}
