using System;

/**
 * 5.39 (Infinite Series: e^x) 
 * Write an app that computes the value of ex by using the formula Compare the result of your calculation to the return 
 * value of the method call Math.Pow( Math.E, x ) [Note: The predefined method Math.Pow takes two arguments and raises 
 * the first argument to the power of the second. We discuss Math.Pow in Section 6.4.]
 */ 
namespace CHP05PE39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double e = 1;
            int counter = 1;

            while (counter != number)
            {
                int counter2 = counter++;
                int sum = 1;
                int counter3 = 1;
                while (counter2 != 0)
                {
                    sum *= counter2--;
                    if (counter2 == 0)
                        e += (Math.Pow(number, counter3++) / sum);
                }

                if (counter == number)
                    Console.WriteLine("My approximation of E is {0}.", e);
            }
        }
    }
}
