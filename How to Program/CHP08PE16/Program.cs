using System;

/**
 * 8.16 (Using the foreach Statement) 
 * Write an app that uses a foreach statement to sum the double values passed by the command-line arguments. 
 * [Hint: Use static method ToDouble of class Convert to convert a string to a double value.]
 */ 
namespace CHP08PE16
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            double[] typeDoubleArray;

            if (args.Length == 0)
            {
                Console.WriteLine("No command line arguments found! Setting default size to 10..");
                arraySize = 10;
            } 
            else
            {
                Console.WriteLine("Setting array size to {0}.", args[0]);
                arraySize = int.Parse(args[0]);
            }

            typeDoubleArray = new double[arraySize];

            Console.WriteLine("Initializing type double array values...");

            for (int arrayIndex = 0; arrayIndex < typeDoubleArray.Length; arrayIndex++)
            {
                Console.Write("Enter value {0}: ", arrayIndex + 1);
                typeDoubleArray[arrayIndex] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Summing up array values...");
            double sum = 0;
            int counter = 0; 

            foreach (double values in typeDoubleArray)
            {
                sum += values;

                Console.Write(values);

                if (counter++ != typeDoubleArray.Length - 1)
                    Console.Write(" + ");
            }

            Console.WriteLine(" = {0}", sum);
        }
    }
}
