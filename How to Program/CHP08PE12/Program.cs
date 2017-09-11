using System;

/**
 * 8.12 (Duplicate Elimination) 
 * Use a one-dimensional array to solve the following problem: 
 * Write an app that inputs five numbers, each of which is between 10 and 100, inclusive. As each number is read, display it 
 * only if it’s not a duplicate of a number already read. Use the smallest possible array to solve this problem. 
 * Display the complete set of unique values input after the user inputs each new value.
 */ 
namespace CHP08PE12
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 5;
            int[] nonDuplicateArr = new int[SIZE];

            requestFiveNonDuplicateIntegers(nonDuplicateArr);

            foreach (int number in nonDuplicateArr)
                Console.Write(number + " ");
        }

        public static void requestFiveNonDuplicateIntegers(int[] nonDuplicateArr)
        {
            int nonDuplicateCounter = 0, input;

            Console.WriteLine("Enter a number between 10 to 100: ");

            while (nonDuplicateCounter != 5)
            {
                Console.Write("Number {0}: ", (nonDuplicateCounter + 1));
                input = Convert.ToInt32(Console.ReadLine());

                while (input < 10 | input > 100)
                {
                    Console.WriteLine("Number has to be between 10 to 100! Try again!");
                    Console.Write("Number {0}: ", (nonDuplicateCounter + 1));
                    input = Convert.ToInt32(Console.ReadLine());
                }

                if (nonDuplicateCounter == 0 | checkForDuplicateInArray(input, nonDuplicateArr))
                    nonDuplicateArr[nonDuplicateCounter++] = input;
                else
                    Console.WriteLine("Duplicate found! Enter another number!");
            }
        }

        public static Boolean checkForDuplicateInArray(int input, int[] nonDuplicateArr)
        {
            for (int i = 0; i < nonDuplicateArr.Length; i++)
                if (nonDuplicateArr[i] == input)
                    return false;

            return true;
        }
    }
}
