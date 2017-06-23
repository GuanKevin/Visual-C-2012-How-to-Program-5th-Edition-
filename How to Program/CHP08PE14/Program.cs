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
            Boolean continueArraySeries;

            do
            {
                Console.Write("Enter size of array: ");
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] myArray = new int[arraySize];

                for (int arrayIndex = 0; arrayIndex < myArray.Length; arrayIndex++)
                {
                    Console.Write("Enter number {0}: ", arrayIndex + 1);
                    myArray[arrayIndex] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Caculating product...");
                int arraySeriesProduct = 1;

                for (int arrayIndex = 0; arrayIndex < myArray.Length; arrayIndex++)
                {
                    Console.Write(myArray[arrayIndex]);

                    if (myArray.Length - 1 != arrayIndex)
                        Console.Write(" * ");

                    arraySeriesProduct *= myArray[arrayIndex];
                }

                Console.WriteLine(" = {0}", arraySeriesProduct);
                Console.Write("Test another series (Y|N): ");

                if (char.ToLower(Convert.ToChar(Console.Read())) == 'y')
                {
                    continueArraySeries = true;
                    Console.ReadLine();
                }
                else
                {
                    continueArraySeries = false;
                    Console.WriteLine("Ending calculations...");
                }

            } while (continueArraySeries);
        }
    }
}
