using System;

/**
 * 7.39 (Computer-Assisted Instruction) 
 * The use of computers in education is referred to as computer- assisted instruction (CAI). Write a program that will 
 * help an elementary school student learn multiplication. Use a Random object to produce two positive one-digit integers. 
 * The program should then prompt the user with a question, such as How much is 6 times 7? The student then inputs the 
 * answer. Next, the program checks the student’s answer. If it’s correct, display the message "Very good!" and ask 
 * another multiplication question. If the answer is wrong, display the message "No. Please try again." and let the 
 * student try the same question repeatedly until the student gets it right. A separate function should be used to 
 * generate each new question. This function should be called once when the app begins execution and each time the 
 * user answers the question correctly.
 */ 
namespace CHP07PE39
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
                    Console.WriteLine("No. Please try again.");
                    Console.Write("{0} x {1} = ", number1, number2);
                    product = Convert.ToInt32(Console.ReadLine());
                }
                else
                    break;
            }
        }

        public int GetRandomNumber()
        {
            return randNumber.Next(1, 10);
        }
    }
}
