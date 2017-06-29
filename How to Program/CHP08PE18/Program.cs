using System;

/**
 * 8.18 (Game of Craps) 
 * Write an app that runs 1000 games of craps (Fig. 7.8) and answers the following questions: 
 * a) How many games are won on the first roll, second roll, …, twentieth roll and after the twentieth roll? 
 * b) How many games are lost on the first roll, second roll, …, twentieth roll and after the twentieth roll? 
 * c) What are the chances of winning at craps? [Note: You should discover that craps is one of the fairest casino games.]
 * d) What is the average length of a game of craps?
 */ 
namespace CHP08PE18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Position [0] stores all wins
            // Position [1] stores all loses
            byte[,] jaggedArrayForCraps = new byte[2, 22];

            Craps playCraps;

            for (int i = 0; i < 1000; i++)
            {
                playCraps = new Craps();

                // Player wins
                if ((int) playCraps.GameResult() == 1)
                {
                    // Games won after the 20th roll
                    if (playCraps.GetRunsCounter() > 20)
                        jaggedArrayForCraps[0, 21]++;
                    // Games won between the 1st to 20th roll
                    else
                        jaggedArrayForCraps[0, playCraps.GetRunsCounter()]++;
                }
                // Player loses
                else
                {
                    // Games won after the 20th roll
                    if (playCraps.GetRunsCounter() > 20)
                        jaggedArrayForCraps[1, 21]++;
                    // Games won between the 1st to 20th roll
                    else
                        jaggedArrayForCraps[1, playCraps.GetRunsCounter()]++;
                }
            }

            Console.WriteLine("Runs{0, 8}{1, 10}", "Wins", "Lose");
            for (int i = 1; i <= 21; i++)
            {
                Console.WriteLine(i + "{0, 10}{1, 10}", jaggedArrayForCraps[0, i], jaggedArrayForCraps[1, i]);
            }
        }
    }
}
