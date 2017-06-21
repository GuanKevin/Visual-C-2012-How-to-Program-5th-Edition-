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
            Random randNum = new Random();

            for (int i = 0; i < 10; i++)
            {
                int num = randNum.Next(1001);
                if (IsEven(num))
                    Console.WriteLine(num + " is even!");
                else
                    Console.WriteLine(num + " is odd!");
            }
        }    
        
        public static Boolean IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }
    }
}
