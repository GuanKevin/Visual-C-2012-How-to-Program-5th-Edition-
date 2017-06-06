using System;

/**
 * 3.24 (Odd or Even) 
 * Write an app that reads an integer, then determines and displays whether it’s odd or even. 
 * [Hint: Use the remainder operator. An even number is a multiple of 2. 
 * Any multiple of 2 leaves a remainder of 0 when divided by 2.]
 */
namespace CHP03PE24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number entered is {0}.", number);

            if (number % 2 == 0)
                Console.WriteLine("{0} % 2 == {1}, therefore it is even!", number, (number % 2));
            else
                Console.WriteLine("{0} % 2 == {1}, therefore it is odd!", number, (number % 2));
        }
    }
}
