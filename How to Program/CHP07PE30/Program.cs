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
            Boolean keepPlaying = true;
            do
            {
                keepPlaying = new Program().GuessNumber();
                Console.ReadLine();
            } while (keepPlaying);
        }

        public Boolean GuessNumber()
        {
            Console.WriteLine("Guess the number between 1 to 100!");
            Random randNum = new Random();
            int number = randNum.Next(1, 101),
                guess;
            Boolean userGuess = false;

            while (!userGuess)
            {
                Console.Write("Enter guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                // If the player's guess is incorrect, your app should display 
                // Too high.
                // or Too low.

                if (guess > number)
                    Console.Write("Too high. ");
                else if (guess < number)
                    Console.Write("Too low. ");
                else
                {
                    Console.WriteLine("Congratulations. You guessed the number!");
                    userGuess = true;
                    Console.Write("Would you like to play again (Y|N): ");

                    if (char.ToLower(Convert.ToChar(Console.Read())) == 'y')                   
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}
