using System;

/**
 * 8.12 (Duplicate Elimination) 
 * Use a one-dimensional array to solve the following problem: 
 * Write an app that inputs five numbers, each of which is between 10 and 100, inclusive. As each number is read, display it 
 * only if it’s not a duplicate of a number already read. Provide for the “worst case,” in which all five numbers are different. 
 * Use the smallest possible array to solve this problem. Display the complete set of unique values input after the user inputs 
 * each new value.
 */ 
namespace CHP08PE12
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 5;
            int[] noDuplicateArray = new int[ARRAY_SIZE];

            for (int arrayIndex = 0; arrayIndex < noDuplicateArray.Length; arrayIndex++)
            {
                int number;

                do
                {
                    Console.Write("Enter a number between 10 - 100: ");
                    number = Convert.ToInt32(Console.ReadLine());
                } while (!CheckForDuplicates(noDuplicateArray, number, arrayIndex));

                noDuplicateArray[arrayIndex] = number;
                Console.WriteLine("You've entered {0}.", number);
            }

            DisplayInput(noDuplicateArray);
        }

        public static void DisplayInput(int[] noDuplicateArray)
        {
            Console.Write("Display all non duplicate numbers: ");
            for (int index = 0; index < noDuplicateArray.Length; index++)
                Console.Write("{0} ", noDuplicateArray[index]);

            Console.WriteLine();
        }

        public static Boolean CheckForDuplicates(int[] noDuplicateArray, int number, int arrayIndex)
        {
            for (int index = 0; index <= arrayIndex; index++)
                if (noDuplicateArray[index] == number)
                    return false;

            return true;
        }
    }
}
