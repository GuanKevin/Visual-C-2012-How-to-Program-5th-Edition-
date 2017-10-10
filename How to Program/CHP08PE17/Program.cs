using System;

/**
 * 8.17 (Dice Rolling) 
 * Write an app to simulate the rolling of two dice. The app should use an object of class Random once to roll the first die 
 * and again to roll the second die. The sum of the two values should then be calculated. Each die can show an integer value 
 * from 1 to 6, so the sum of the values will vary from 2 to 12, with 7 being the most frequent sum and 2 and 12 the least 
 * frequent sums. Your app should roll the dice 36,000 times. Use a one-dimensional array to tally the number of times each 
 * possible sum appears. Display the results in tabular format. 
 */ 
namespace CHP08PE17
{
    class Dice
    {
        // Use a one-dimensional array to tally the number of times each possible sum appears.
        private const int SIZE = 11;
        // Number of times rolled
        private const int ROLL = 100000;
        //  The app should use an object of class Random
        private Random numberGenerator;
        private int dice_1;
        private int dice_2;
        private int[] tally = new int[SIZE];
        // INDEX: 0 1 2 3 4 5 6 7 8  9  10
        // Value: 2 0 0 0 0 1 0 0 0  0  1 = 36000
        // SUM:   2 3 4 5 6 7 8 9 10 11 12

        /**
         * Constructor
         * Intialize Random object
         */ 
        public Dice()
        {
            numberGenerator = new Random();
            FrequencyList();
            DisplayResult();
        }

        private void DisplayResult()
        {
            for (int i = 0; i < tally.Length; i++)
                Console.WriteLine("{0, -4}{1, 3}", (i + 2), (tally[i]));
        }

        /**
         * Return a list with values that are rolled most often
         * from the sum of two dice
         */ 
        private void FrequencyList()
        {
            for (int i = 0; i < ROLL; i++)            
                tally[DiceRoll() - 2]++;
        }

        private int DiceRoll()
        {
            dice_1 = numberGenerator.Next(6) + 1;
            dice_2 = numberGenerator.Next(6) + 1;

            return dice_1 + dice_2;
        }

        public static void Main(String[] args)
        {
            Dice dice = new Dice();
        }
    }
}
