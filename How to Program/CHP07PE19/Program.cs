using System;

/**
 * 7.19 (Displaying a Square of Any Character) 
 * Modify the method created in Exercise 7.18 to form the square out of whatever character is contained in character 
 * parameter FillCharacter. Thus, if side is 5 and FillCharacter is '#', the method should display
 * #####
 * #####
 * #####
 * #####
 * #####
 * [Hint: Use the expression Convert.ToChar(Console.Read()) to read a character from the user.]
 */ 
namespace CHP07PE19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char fillCharacter = Convert.ToChar(Console.Read());
            Console.ReadLine();
            Console.Write("Enter a number: ");
            SquareOfCharacters(Convert.ToInt32(Console.ReadLine()), fillCharacter);
        }

        public static void SquareOfCharacters(int number, char fillCharacter)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                    Console.Write("{0} ", fillCharacter);
                Console.WriteLine();
            }
        }
    }
}
