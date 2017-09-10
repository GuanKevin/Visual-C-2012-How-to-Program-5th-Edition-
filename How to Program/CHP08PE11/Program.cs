using System;

/**
 * 8.11 (Array Manipulations) 
 * Write statements that perform the following one-dimensional-array operations: 
 * a) Set the three elements of integer array counts to 0.
 * b) Add 1 to each of the four elements of integer array bonus. 
 * c) Display the five values of integer array bestScores in column format.
 */ 
namespace CHP08PE11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the five values of integer array bestScores in column format.
            int[] bestScores = new int[5];

            for (int i = 0; i < bestScores.Length; i++)
                Console.WriteLine(i + ": " + bestScores[i]);

            // Add 1 to each of the four elements of integer array bonus. 
            /*
            int[] bonus = new int[4];

            for (int i = 0; i < bonus.Length; i++)
                bonus[i] = 1;

            for (int i = 0; i < bonus.Length; i++)
                Console.WriteLine(i + ": " + bonus[i]);

            // Set the three elements of integer array counts to 0.      
             * int[] array = { 0, 0, 0 };

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(i + ": " + array[i]);

            for (int i = 0; i < 3; i++)
                array[i] = 0;

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(i + ": " + array[i]);
                */
        }
    }
}
