using System;

/**
 * 8.17 (Dice Rolling) 
 * Write an app to simulate the rolling of two dice. The app should use an object of class Random once to roll the first die 
 * and again to roll the second die. The sum of the two values should then be calculated. Each die can show an integer value 
 * from 1 to 6, so the sum of the values will vary from 2 to 12, with 7 being the most frequent sum and 2 and 12 the least 
 * frequent sums. Figure 8.24 shows the 36 possible combinations of the two dice. Your app should roll the dice 36,000 times. 
 * Use a one-dimensional array to tally the number of times each possible sumappears. Display the results in tabular format. 
 * Determine whether the totals are reasonable (e.g., there are six ways to roll a 7, so approximately one-sixth of the rolls 
 * should be 7).
 */ 
namespace CHP08PE17
{
    class Program
    {
        Random randNum = new Random();

        static void Main(string[] args)
        {
            Program diceRolling = new Program();

            int[] simulateDiceArray = new int[13];
            for (int i = 0; i < 36000; i++)
                ++simulateDiceArray[diceRolling.RollDice()];

            diceRolling.DisplaySimulationResults(simulateDiceArray);
        }

        public void DisplaySimulationResults(int[] simulateDiceArray)
        {
            Console.WriteLine("Dice_Sum{0, 10}", "Results");
            for (int arrayIndex = 2; arrayIndex < simulateDiceArray.Length; arrayIndex++)
            {
                Console.WriteLine("{0}{1, 15}", arrayIndex, simulateDiceArray[arrayIndex]);
            }
        }

        public int RollDice()
        {
            int roll1 = randNum.Next(1, 7);
            int roll2 = randNum.Next(1, 7);

            return (roll1 + roll2);
        }
    }
}
