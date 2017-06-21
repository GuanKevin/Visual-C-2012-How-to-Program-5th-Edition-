using System;

/**
 * 7.40 (Computer-Assisted Instruction: Reducing Student Fatigue) 
 * One problem in CAI environments is student fatigue. This can be reduced by varying the computer’s responses to hold 
 * the student’s attention. Modify the program of Exercise 7.39 so that various comments are displayed for each answer. 
 * Possible responses to a correct answer: 
 * Very good! 
 * Excellent! 
 * Nice work! 
 * Keep up the good work! 
 * Possible responses to an incorrect answer: 
 * No. 
 * Please try again. 
 * Wrong. 
 * Try once more. 
 * Don't give up! 
 * No. Keep trying.
 * Use random-number generation to choose a number from 1 to 4 that will be used to select one of the four appropriate 
 * responses to each correct or incorrect answer. Use a switch statement to issue the responses.
 */ 
namespace CHP07PE40
{
    class Program
    {
        Random randNumber = new Random();

        static void Main(string[] args)
        {
            LearnMiltiplication();
        }

        public static void LearnMiltiplication()
        {
            Program instance = new Program();
            int number1 = instance.GetRandomNumber();
            int number2 = instance.GetRandomNumber();

            Console.Write("{0} x {1} = ", number1, number2);
            int product = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (product != (number1 * number2))
                {
                    instance.GetIncorrectResponse();
                    Console.Write("{0} x {1} = ", number1, number2);
                    product = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    instance.GetCorrectResponse();
                    break;
                }
            }
        }

        public void GetCorrectResponse()
        {
            switch (randNumber.Next(4))
            {
                case 0:
                    Console.WriteLine("Very good!");
                    break;
                case 1:
                    Console.WriteLine("Excellent!");
                    break;
                case 2:
                    Console.WriteLine("Nice work!");
                    break;
                case 3:
                    Console.WriteLine("Keep up the good work!");
                    break;
                case 4:
                    Console.WriteLine("Don't give up.");
                    break;
                default:
                    Console.WriteLine("No. Keep trying.");
                    break;

            }
        }

        public void GetIncorrectResponse()
        {
            switch (randNumber.Next(6))
            {
                case 0:
                    Console.WriteLine("No.");
                    break;
                case 1:
                    Console.WriteLine("Please try again.");
                    break;
                case 2:
                    Console.WriteLine("Wrong.");
                    break;
                case 3:
                    Console.WriteLine("Try once more.");
                    break;
                case 4:
                    Console.WriteLine("Don't give up.");
                    break;
                default:
                    Console.WriteLine("No. Keep trying.");
                    break;

            }
        }

        public int GetRandomNumber()
        {
            return randNumber.Next(1, 10);
        }
    }
}
