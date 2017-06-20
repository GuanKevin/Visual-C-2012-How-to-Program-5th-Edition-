using System;

/**
 * 7.17 (Even or Odd) 
 * Write method IsEven that uses the remainder operator (%) to determine whether an integer is even. The method should 
 * take an integer argument and return true if the integer is even and false otherwise. Incorporate this method into an 
 * app that inputs a sequence of integers (one at a time) and determines whether each is even or odd.
 */ 
namespace CHP07PE17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (negative number to quit!): ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                if (IsEven(number))
                    Console.WriteLine("{0} is even!", number);
                else
                    Console.WriteLine("{0} is odd!", number);

                Console.Write("Enter a number (negative number to quit!): ");
                number = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static Boolean IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
