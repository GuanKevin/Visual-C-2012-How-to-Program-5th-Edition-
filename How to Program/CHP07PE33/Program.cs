using System;

/**
 * 7.33 (Craps Game Modification) 
 * Modify the craps app of Fig. 7.8 to allow wagering. Initialize variable balance to 1000 dollars. Prompt the player to 
 * enter a wager. Check that wager is less than or equal to balance, and if it’s not, have the user reenter wager until a 
 * valid wager is entered. After a correct wager is entered, run one game of craps. If the player wins, increase balance 
 * by wager and display the new balance. If the player loses, decrease balance by wager, display the new balance, check 
 * whether balance has become zero and, if so, display the message "Sorry. You busted!"
 */
namespace CHP07PE33
{
    class Program
    {
        private static Random randomNumbers = new Random();
        private enum Status { CONTINUE, WON, LOST }
        private enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            SEVEN = 7,
            YO_LEVEN = 11,
            BOX_CARS = 12
        }

        static void Main(string[] args)
        {
            Status gameStatus = Status.CONTINUE;
            int myPoint = 0;
            int sumOfDice = RollDice();

            switch ((DiceNames) sumOfDice)
            {
                case DiceNames.SEVEN:
                case DiceNames.YO_LEVEN:
                    gameStatus = Status.WON;
                    break;
                case DiceNames.SNAKE_EYES:
                case DiceNames.TREY:
                case DiceNames.BOX_CARS:
                    gameStatus = Status.LOST;
                    break;
                default:
                    gameStatus = Status.CONTINUE;
                    myPoint = sumOfDice;
                    Console.WriteLine("Point is {0}", myPoint);
                    break;
            }

            while (gameStatus == Status.CONTINUE)
            {
                sumOfDice = RollDice();
                if (sumOfDice == myPoint)
                    gameStatus = Status.WON;
                else if (sumOfDice == (int)DiceNames.SEVEN)
                    gameStatus = Status.LOST;
            }

            if (gameStatus == Status.WON)
                Console.WriteLine("Player Wins");
            else
                Console.WriteLine("Player Loses");                
        }
        public static int RollDice()
        {
            int die1 = randomNumbers.Next(1, 7);
            int die2 = randomNumbers.Next(1, 7);

            int sum = die1 + die2;
            Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);
            return sum;
        }
    }
}
