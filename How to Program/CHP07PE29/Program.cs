using System;

/**
 * 7.29 (Coin Tossing) 
 * Write an app that simulates coin tossing. Let the app toss a coin each time the user chooses the “Toss Coin” menu 
 * option. Count the number of times each side of the coin appears. Display the results. The app should call a separate 
 * method Flip that takes no arguments and returns false for tails and true for heads. [Note: If the app realistically 
 * simulates coin tossing, each side of the coin should appear approximately half the time.]
 */ 
namespace CHP07PE29
{
    class Program
    {
        static Random randToss = new Random();

        static void Main(string[] args)
        {
            //Let the app toss a coin each time the user chooses the “Toss Coin” menu option.

            Console.WriteLine("Menu" +
                "\nToss Coin: 1" +
                "\nEnd Toss: 0");

            // The app should call a separate 
            // method Flip that takes no arguments and returns false for tails and true for heads.

            for (int i = 0; i <= 10; i++)
                if (new Program().Flip())
                    Console.WriteLine("Head");
                else
                    Console.WriteLine("Tail");
        }

        public Boolean Flip()
        {
            if (randToss.Next(2) == 0)
                return false;
            return true;
        }
    }
}
