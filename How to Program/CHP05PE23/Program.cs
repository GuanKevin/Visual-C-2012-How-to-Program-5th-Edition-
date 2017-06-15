using System;

/**
 * 5.23 (Find the Two Largest Numbers) 
 * Using an approach similar to that for Exercise 5.21, find the two largest values of the 10 values entered. 
 * [Note: You may input each number only once.]
 */
namespace CHP05PE23
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number = int.MinValue;
            int largest = int.MinValue;
            int secondlargest = int.MinValue;

            while (counter++ < 10)
            {
                Console.Write("Enter number {0}: ", counter);
                number = Convert.ToInt32(Console.ReadLine());

                if (number > secondlargest)
                {
                    secondlargest = number;

                    if (secondlargest > largest)
                    {
                        number = largest;
                        largest = secondlargest;
                        secondlargest = number;
                    }
                }                    
            }

            Console.WriteLine("The largest number is {0} and the second largest is {1}.", largest, number);
        }
    }
}
