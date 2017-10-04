using System;

/**
 * 8.34 (Polling) 
 * The Internet and the web are enabling more people to network, join a cause, voice opinions, and so on. 
 * The presidential candidates in 2012 used the Internet intensively to get out their messages and raise money for their campaigns. 
 * In this exercise, you’ll write a simple polling program that allows users to rate five social-consciousness issues from 
 *      1 (least important) to 10 (most important). 
 * Pick five causes that are important to you (for example, political issues, global environmental issues). 
 * Use a one-dimensional array topics (of type String) to store the five causes. To summarize the survey responses, use a 5-row, 10-column two-dimensional 
 * array responses (of type Integer), each row corresponding to an element in the topics array. When the program runs, it should ask the user to rate each issue. 
 * Have your friends and family respond to the survey. Then have the program display a summary of the results, including:
 *      a) A tabular report with the five topics down the left side and the 10 ratings across the top, 
 *          listing in each column the number of ratings received for each topic. 
 *      b) To the right of each row, show the average of the ratings for that issue.
 *      c) Which issue received the highest point total? Display both the issue and the point total.
 *      d) Which issue received the lowest point total? Display both the issue and the point total.
 */
namespace CHP08PE34
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use a one-dimensional array topics (of type String) to store the five causes.
            string[] socialCauses = new String[]{ "Veterans_Foundation", "Cancer_Research", "Child_Assistance", "Human_Civil_Rights", "Environmental_Defense"};

            // use a 5-row, 10-column two-dimensional array responses(of type Integer), each row corresponding to an element in the topics array.
            int[,] pollResponses = new int[5, 10];

            // When the program runs, it should ask the user to rate each issue. 
            new Program().StartPoll(socialCauses, pollResponses);
        }

        /**
         * Simple polling method that allows users to rate 
         * five social-consciousness issues from 
         * 1 (least important) to 10 (most important). 
         */
        private void StartPoll(string[] socialCauses, int[,] pollResponses)
        {            
            RatePoll(socialCauses, pollResponses);
            // DisplayCauses(socialCauses);
            DisplayPoll(socialCauses, pollResponses);
        }

        /**
         *  a) A tabular report with the five topics down the left side and the 10 ratings across the top
         *  b) To the right of each row, show the average of the ratings for that issue.
         */
        private void DisplayPoll(string[] socialCauses, int[,] pollResponses)
        {
            // Stores the issue's name and points with the highest and lowest total point
            string[,] issues = new string[2, 2];
            string title = String.Format("{0, -25}{1, -6}{2, -6}{3, -6}{4, -6}{5, -6}{6, -6}{7, -6}{8, -6}{9, -6}{10, -6}{11, -6}{12, 9}", 
                "Causes", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Total", "Average");

            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine(title);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            for (int i = 0; i < pollResponses.GetLength(0); i++)
            {
                int totalSum = 0;
                int temp = 0;

                Console.Write("{0, -25}", socialCauses[i]);

                for (int j = 0; j < pollResponses.GetLength(1); j++)
                {
                    totalSum += pollResponses[i, j];
                    Console.Write("{0, -5} ", pollResponses[i, j]);
                    temp = j;
                }

                Console.WriteLine("{0, 5}{1, 10}", totalSum, (totalSum / 10.0));

                // Checks if row 1 is empty or could be replaced
                // Row 1 holds highest point total
                if (issues[0, 1] == null)
                {
                    issues[0, 0] = socialCauses[i];
                    issues[0, 1] = "" + totalSum;
                }
                else if (Convert.ToInt32(issues[0, 1]) < totalSum)
                {
                    issues[0, 0] = socialCauses[i];
                    issues[0, 1] = "" + totalSum;
                }

                // Checks if row 2 is empty or could be replaced
                // Row 1 holds lowest point total
                if (issues[1, 1] == null)
                {
                    issues[1, 0] = socialCauses[i];
                    issues[1, 1] = "" + totalSum;
                }
                else if (Convert.ToInt32(issues[1, 1]) > totalSum)
                {
                    issues[1, 0] = socialCauses[i];
                    issues[1, 1] = "" + totalSum;
                }
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Highest: {0} at {1}.", issues[0, 0], issues[0, 1]);
            Console.WriteLine("Lowest: {0} at {1}.", issues[1, 0], issues[1, 1]);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }

        /**
         * Respond to the survey
         * 1 (least important) to 10 (most important).
         */
        private void RatePoll(string[] socialCauses, int[,] pollResponses)
        {
            // For AutoFilling the polls
            Random randNum = new Random();

            for (int i = 0; i < pollResponses.GetLength(1); i++)
            {
                Console.WriteLine("Enter a number beteween 1 (least important) to 10 (most important).");
                Console.WriteLine("Poller {0}: ", (i + 1));
                for (int j = 0; j < pollResponses.GetLength(0); j++)
                {
                    Console.Write("{0}: ", socialCauses[j]);
                    // pollResponses[j, i] = Convert.ToInt32(Console.ReadLine());                    
                    pollResponses[j, i] = randNum.Next(10) + 1;                }
                Console.Clear();
            }
        }

        /**
         * Display the causes
         */
        private void DisplayCauses(string[] socialCauses)
        {
            String formatCauses = String.Format("{0, -10}{1, 0}{2, 18}{3, 20}{4, 22}{5, 25}", 
                "Causes", socialCauses[0], socialCauses[1], socialCauses[2], socialCauses[3], socialCauses[4]);

            Console.WriteLine(formatCauses);
        }
    }
}
