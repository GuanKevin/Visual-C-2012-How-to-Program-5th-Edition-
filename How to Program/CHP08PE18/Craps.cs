using System;

public class Craps
{
    private static Random randomNumbers = new Random();
    private Status gameStatus;
    private int runsCounter;

    public enum Status { CONTINUE, WON, LOST }

    public enum DiceNames
    {
        SNAKE_EYES = 2,
        TREY = 3,
        SEVEN = 7,
        YO_LEVEN = 11,
        BOX_CARS = 12
    }

    public Craps() { this.runsCounter = 0; PlayCraps(); }

    public int GetRunsCounter() { return runsCounter; }
    public Status GameResult() { return gameStatus; }

    public void PlayCraps()
    {
        gameStatus = Status.CONTINUE;
        int myPoint = 0;
        int sumOfDice = RollDice();

        GameStatus(sumOfDice, myPoint);       
    }

    private void GameStatus(int sumOfDice, int myPoint)
    {
        runsCounter++;
        switch ((DiceNames) sumOfDice)
        {
            case DiceNames.SEVEN: // win with 7 on first roll
            case DiceNames.YO_LEVEN: // win with 11 on first roll
                {
                    gameStatus = Status.WON;
                    // Console.WriteLine("Player wins");
                    break;
                }
            case DiceNames.SNAKE_EYES: // lose with 2 on first roll
            case DiceNames.TREY: // lose with 3 on first roll
            case DiceNames.BOX_CARS: // lose with 12 on first roll
                {
                    gameStatus = Status.LOST;
                    // Console.WriteLine("Player loses");
                    break;
                }
            default: // did not win or lose, so remember point
                gameStatus = Status.CONTINUE; // game is not over
                myPoint = sumOfDice; // remember the point
                // Console.WriteLine("Point is {0}", myPoint);
                break;
        }

        while (gameStatus == Status.CONTINUE) // game not WON or LOST
        {
            runsCounter++;
            sumOfDice = RollDice(); // roll dice again

            // determine game status
            if (sumOfDice == myPoint) // win by making point
                gameStatus = Status.WON;
            else
                // lose by rolling 7 before point
                if (sumOfDice == (int)DiceNames.SEVEN)
                gameStatus = Status.LOST;

            // display won or lost message
           /* if (gameStatus == Status.WON)
                Console.WriteLine("Player wins");
            else if (gameStatus == Status.LOST)
                Console.WriteLine("Player loses"); */
        }
    }

    private int RollDice()
    {
        // pick random die values
        int die1 = randomNumbers.Next(1, 7); // first die roll
        int die2 = randomNumbers.Next(1, 7); // second die roll

        int sum = die1 + die2; // sum of die values

        // display results of this roll
        // Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);
        return sum; // return sum of dice
    }
}