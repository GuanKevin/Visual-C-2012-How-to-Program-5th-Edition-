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
        static void Main(string[] args)
        {
            Console.Write("Enter 1 to flip the coin, 0 to stop: " + 
                "\nEnter 0 or 1: ");
            int coin = Convert.ToInt32(Console.ReadLine());
            int flipCounter = 0;
            int headCounter = 0;

            while (coin == 1)
            {
                flipCounter++;
                if (FlipCoin())
                {
                    headCounter++;
                    Console.WriteLine("Flipped a head!");
                }
                else
                    Console.WriteLine("Flipped a tail!");

                Console.Write("Enter 0 or 1: ");
                coin = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Heads: {0}", headCounter);
            Console.WriteLine("Tails: {0}", (flipCounter - headCounter));
        }

        public static Boolean FlipCoin()
        {
            Random randomNumber = new Random();

            if (randomNumber.Next(1, 3) == 1)
                return true;
            else
                return false;
        }
    }
}
