using System;
/**
 * 8.15 (Command-Line Arguments) 
 * Rewrite Fig. 8.2 so that the array’s size is specified by the first command-line argument. 
 * If no command-line argument is supplied, use 10 as the default size.
 */ 
namespace CHP08PE15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandLineArray = new int[0];
            int sizeOfArray = 10;

            if (args.Length == 0)
            {                
                Console.WriteLine("No command-line argument found, setting default array size to {0}.", sizeOfArray);
                // If no command-line argument is supplied, use 10 as the default size.
                commandLineArray = new int[sizeOfArray];
            }
            else
            {
                Console.WriteLine("Command-line argument found, setting array size to {0}.", int.Parse(args[0]));
                commandLineArray = new int[int.Parse(args[0])];
            }

            for (int i = 0; i < commandLineArray.Length; i++)
            {
                Console.WriteLine("{0, -4}{1}", i, commandLineArray[i]);
            }
        }
    }
}
