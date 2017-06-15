using System;

/**
 * 5.21 (Find the Largest Number) 
 * The process of finding the maximum value (i.e., the largest of a group of values) is used frequently in computer 
 * applications. For example, an app that determines the winner of a sales contest would input the number of units sold by 
 * each salesperson. The salesperson who sells the most units wins the contest. Write a C# app that inputs a series of 10 
 * integers, then determines and displays the largest integer. Your app should use at least the following three variables:
 * a) counter: A counter to count to 10 (i.e., to keep track of how many numbers have been input 
 *              and to determine when all 10 numbers have been processed).
 * b) number: The integer most recently input by the user. 
 * c) largest: The largest number found so far.
 */
namespace CHP05PE21
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number;
            int largest = int.MinValue;
            
            while (counter++ != 10)
            {
                Console.Write("Enter number {0}: ", counter);
                number = Convert.ToInt32(Console.ReadLine());

                if (number > largest)
                    largest = number;
            }

            Console.WriteLine("The largest number entered was {0}.", largest);
        }
    }
}
