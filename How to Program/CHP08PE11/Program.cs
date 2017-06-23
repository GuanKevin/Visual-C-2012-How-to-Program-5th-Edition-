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
            int[] bestScores = new int[10];

            for (int i = 0; i < 3; i++)
                bestScores[i] = 0;

            for (int i = 0; i < 4; i++)
                ++bestScores[i];

            for (int i = 0; i < 5; i++)
                Console.WriteLine(bestScores[i]);
        }
    }
}
