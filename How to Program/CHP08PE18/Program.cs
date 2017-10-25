using System;

/**
 * 8.18 (Game of Craps) 
 * Write an app that runs 1000 games of craps (Fig. 7.8) and answers the following questions: 
 * a) How many games are won on the first roll, second roll, …, twentieth roll and after the twentieth roll? 
 * b) How many games are lost on the first roll, second roll, …, twentieth roll and after the twentieth roll? 
 * c) What are the chances of winning at craps? 
 *      [Note: You should discover that craps is one of the fairest casino games.]
 * d) What is the average length of a game of craps?
 */
namespace CHP08PE18
{
    public class Craps
    {
        // create random-number generator for use in method RollDice
        private static Random randomNumbers = new Random();

        // enumeration with constants that represent the game status
        private enum Status { CONTINUE, WON, LOST }

        // enumeration with constants that represent common rolls of the dice
        private enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            SEVEN = 7,
            YO_LEVEN = 11,
            BOX_CARS = 12
        }

        // Store the number of games to be played
        private int numberOfGames;

        // Tracks users points 
        private int myPoint;

        // Store the number of games won and lost depending on the number of rolls
        private int[] numOfWins = new int[21];
        private int[] numOfLoses = new int[21];

        // Constructor: Initialize the number of games to be played
        public Craps() : this (1000) { }

        // Constructor: Allow user to initialize the number of games to be played
        public Craps(int numberOfGames) 
        {
            this.numberOfGames = numberOfGames;
            PlayCraps();
        }

        // Starts the game of craps
        private void PlayCraps()
        {
            int numberOfGamesPlayed = 0;

            while (numberOfGamesPlayed++ < numberOfGames)
            {
                // gameStatus can contain CONTINUE, WON or LOST
                Status gameStatus = Status.CONTINUE;
                myPoint = 0; // point if no win or loss on first roll
                int numberOfRolls = 1; // Number of rolls in a game
                int sumOfDice = RollDice(); // first roll of the dice

                gameStatus = FirstRoll(sumOfDice, gameStatus); // Gets the status of the game after the first roll

                while (gameStatus == Status.CONTINUE) // game not WON or LOST
                {
                    numberOfRolls++;
                    gameStatus = KeepRolling(sumOfDice, gameStatus);
                } // end of inner while loop

                TrackRolls(numberOfRolls, gameStatus); // Records the win or lose on the specific roll
                
                // display won or lost message
                /*
                if (gameStatus == Status.WON)
                    Console.WriteLine("Player wins");
                else
                    Console.WriteLine("Player loses");
                */
            } // end of outer while loop

            DisplayResults();
        }

        /**
         * Display the number of games won or lost depending on the number of rolls
         */ 
        private void DisplayResults()
        {
            Console.WriteLine("{0, -15}{1}{2, 10}", "#_Of_Rolls", "Wins", "Loses");

            int avgGameLength = 0;

            for (int i = 1; i < numOfWins.Length; i++)
            {
                // How many games are won on the first roll, second roll, …, 
                // How many games are lost on the first roll, second roll, …, 
                Console.WriteLine("{0, -15}{1}{2, 10}", (i), numOfWins[i], numOfLoses[i]);

                avgGameLength += (numOfWins[i] * i);
                avgGameLength += (numOfLoses[i] * i);
            }
            // twentieth roll and after the twentieth roll? 
            // twentieth roll and after the twentieth roll? 
            Console.WriteLine("{0, -15}{1}{2, 10}", ("21+"), numOfWins[0], numOfLoses[0]);
            avgGameLength += (numOfWins[0] * 21);
            avgGameLength += (numOfLoses[0] * 21);

            // What are the chances of winning at craps?
            int numberOfWins = CalculateSumOfGamesPlayed(numOfWins);
            int numberOfLoses = CalculateSumOfGamesPlayed(numOfLoses);
            Console.WriteLine("Change of winning is {0} or {1}%", 
                (numberOfWins + "/" + (numberOfWins + numberOfLoses)),
                ((numberOfWins / (double) (numberOfWins + numberOfLoses)) * 100));

            // What is the average length of a game of craps?
            Console.WriteLine("The average length of a game is {0}.", avgGameLength / 1000.0);
        }

        /**
         * return the sum of the games played
         */
        private int CalculateSumOfGamesPlayed(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            return sum;
        }

        /**
         * Keep track of the number of wins or loses 
         * in specified index
         * If user takes more than 20 rolls to win or lose
         * then index 0 is used to store that win or lose
         */
        private void TrackRolls(int numberOfRolls, Status gameStatus)
        {
            if (gameStatus == Status.WON)
            {
                if (numberOfRolls <= 20)
                    numOfWins[numberOfRolls]++;
                else
                    numOfWins[0]++; // Stores wins if it took more than 20 rolls
            }
            else if (gameStatus == Status.LOST)
            {
                if (numberOfRolls <= 20)
                    numOfLoses[numberOfRolls]++;
                else
                    numOfLoses[0]++; // Stores loses if it took more than 20 rolls
            }
        }

        /**
         * Roll the dice again to get the sum
         * and return the updated game status
         */
        private Status KeepRolling(int sumOfDice, Status gameStatus)
        {
            sumOfDice = RollDice(); // roll dice again
                                    // determine game status
            if (sumOfDice == myPoint) // win by making point
                gameStatus = Status.WON;
            else if (sumOfDice == (int)DiceNames.SEVEN) // lose by rolling 7 before point
                gameStatus = Status.LOST;

            return gameStatus;
        }

        /**
         * Check the value of the first roll of the game
         * and returns the game status
         */ 
        private Status FirstRoll(int sumOfDice, Status gameStatus)
        {
            // determine game status and point based on first roll
            switch ((DiceNames)sumOfDice)
            {
                case DiceNames.SEVEN: // win with 7 on first roll
                case DiceNames.YO_LEVEN: // win with 11 on first roll
                    gameStatus = Status.WON;
                    break;
                case DiceNames.SNAKE_EYES: // lose with 2 on first roll
                case DiceNames.TREY: // lose with 3 on first roll
                case DiceNames.BOX_CARS: // lose with 12 on first roll
                    gameStatus = Status.LOST;
                    break;
                default: // did not win or lose, so remember point
                    gameStatus = Status.CONTINUE; // game is not over
                    myPoint = sumOfDice; // remember the point
                    // Console.WriteLine("Point is {0}", myPoint);
                    break;
            } // end switch

            return gameStatus;
        }

        // roll dice, calculate sum and display results
        public static int RollDice()
        {
            // pick random die values
            int die1 = randomNumbers.Next(1, 7); // first die roll
            int die2 = randomNumbers.Next(1, 7); // second die roll

            int sum = die1 + die2; // sum of die values

            // display results of this roll
            // Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);
            return sum; // return sum of dice
        } // end method RollDice

        // plays one game of craps
        public static void Main(string[] args)
        {
            Craps crap = new Craps();

            Console.ReadLine();
        } // end Main

    } // end class Craps
}