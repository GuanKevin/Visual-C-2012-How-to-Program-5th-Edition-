using System;

/**
 * 8.14 (Variable-Length Argument List) 
 * Write an app that calculates the product of a series of integers that are passed to method product using a variable-length 
 * argument list. Test your method with several calls, each with a different number of arguments.
 */ 
namespace CHP08PE14
{
    class Program
    {   
        static void Main(string[] args)
        {
            CalculateSeriesOfIntegers();
        }

        public static void CalculateSeriesOfIntegers()
        {
            Boolean calculateAgain;
            // Use a loop to ask the user to input all the numbers in an array
            do
            {
                // Ask the user for the size of the list of integers
                Console.Write("Enter size of list: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] productArray = new int[size];

                // Use a loop to store the list of numbers that the user will input
                for (int index = 0; index < size; index++)
                {
                    Console.Write("Enter number {0}: ", index + 1);
                    productArray[index] = Convert.ToInt32(Console.ReadLine());
                }

                // Call another method to get the product
                int product = CalculateSeries(productArray);

                Console.WriteLine("The product is {0}.", product);

                // Check if user want to calculate the series again
                Console.Write("Do you want to calculate again (y|n): ");
                char again = Console.ReadKey().KeyChar;
                Console.ReadLine();

                if (again == 'y' || again == 'Y')
                    calculateAgain = true;
                else
                    calculateAgain = false;

            } while (calculateAgain);
        }

        public static int CalculateSeries(int[] productArray)
        {
            if (productArray.Length == 0)
                return 0;

            int result = 1;

            for (int index = 0; index < productArray.Length; index++)
                result *= productArray[index];

            return result;
        }
    }
}
