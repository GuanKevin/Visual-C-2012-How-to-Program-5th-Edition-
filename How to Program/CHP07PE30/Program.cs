using System;

/**
 * 7.30 (Guess the Number Game) 
 * Write an app that plays “guess the number” as follows: Your app chooses the number to be guessed by selecting a 
 * random integer in the range 1 to 1000. The app displays the prompt Guess a number between 1 and 1000. The player 
 * inputs a first guess. If the player's guess is incorrect, your app should display Too high. Try again. or Too low. 
 * Try again. to help the player “zero in” on the correct answer. The app should prompt the user for the next guess. 
 * When the user enters the correct answer, display Congratulations. You guessed the number! and allow the user to choose 
 * whether to play again. [Note: The guessing technique employed in this problem is similar to a binary search, which is 
 * discussed in Chapter 18.]
 */ 
namespace CHP07PE30
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessTheNumber();
        }

        public static void GuessTheNumber()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 1001);
            int guessCounter = 0;

            Console.Write("Enter your guess: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            while (number != userGuess)
            {
                guessCounter++;
                Console.Write("Try a {0} number: ", (number > userGuess) ? "larger" : "smaller");                
                userGuess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You've got it in {0} tries!", guessCounter);
        }
    }
}
