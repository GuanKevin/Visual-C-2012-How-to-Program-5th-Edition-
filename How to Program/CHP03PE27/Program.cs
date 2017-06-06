using System;

/**
 * 3.27 (Integer Equivalent of a Character) 
 * C# can also represent uppercase letters, lowercase letters and a considerable variety of special symbols. 
 * Every character has a corresponding integer representation. The set of characters a computer uses and the corresponding 
 * integer representations for those characters is called that computer’s character set. You can indicate a character 
 * value in an app simply by enclosing that character in single quotes, as in 'A'. You can determine the integer equivalent 
 * of a character by preceding that character with (int), as in (int) 'A' The keyword int in parentheses is known as a cast 
 * operator, and the entire expression is called a cast expression. The following statement outputs a character and its 
 * integer equivalent: Console.WriteLine( "The character {0} has the value {1}", 'A', ( ( int ) 'A' ) ); 
 * When the preceding statement executes, it displays the character A and the value 65 as part of the string. 
 * Using statements similar to the one shown earlier in this exercise, write an app that displays 
 * the integer equivalents of some uppercase letters, lowercase letters, digits and special symbols. 
 * Display the integer equivalents of the following: A B C a b c 0 1 2 $ * + / and the space character.
 */
namespace CHP03PE27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The character {0} has the value {1}", 'A', ((int) 'A'));
            Console.WriteLine("The character {0} has the value {1}", 'B', ((int) 'B'));
            Console.WriteLine("The character {0} has the value {1}", 'C', ((int) 'C'));
            Console.WriteLine("The character {0} has the value {1}", 'a', ((int) 'a'));
            Console.WriteLine("The character {0} has the value {1}", 'b', ((int) 'b'));
            Console.WriteLine("The character {0} has the value {1}", 'c', ((int) 'c'));
            Console.WriteLine("The character {0} has the value {1}", '0', ((int) '0'));
            Console.WriteLine("The character {0} has the value {1}", '1', ((int) '1'));
            Console.WriteLine("The character {0} has the value {1}", '2', ((int) '2'));
            Console.WriteLine("The character {0} has the value {1}", '3', ((int) '3'));
            Console.WriteLine("The character {0} has the value {1}", '$', ((int) '$'));
            Console.WriteLine("The character {0} has the value {1}", '*', ((int) '*'));
            Console.WriteLine("The character {0} has the value {1}", '+', ((int) '+'));
            Console.WriteLine("The character {0} has the value {1}", '/', ((int) '/'));
            Console.WriteLine("The character {0} has the value {1}", ' ', ((int) ' '));
        }
    }
}
