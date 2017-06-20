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
            int counter = 0,
                number,
                largest = int.MinValue,
                secondLargest = int.MinValue;

            while (counter++ < 10)
            {
                Console.Write("Enter number {0}: ", counter);
                number = Convert.ToInt32(Console.ReadLine());

                if (number > secondLargest)
                {
                    secondLargest = number;

                    if (secondLargest > largest)
                    {
                        int tempNumber = largest;
                        largest = secondLargest;
                        secondLargest = tempNumber;
                    }
                }
            }

            Console.WriteLine("The largest number is: {0}." +
                "\nThe second largest number is: {1}.", largest, secondLargest);
        }
    }
}
