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
            int arraySize;
            int[] arrayUsingCommandLineForSize;

            if (args.Length == 0)
            {
                Console.WriteLine("No command line argument found... " +
                    "\nSetting default array size to 10...");
                arraySize = 10;
            }
            else
            {
                Console.WriteLine("Command line argument found..." +
                    "\nSetting default size to {0}...", args[0]);
                arraySize = int.Parse(args[0]);
            }

            arrayUsingCommandLineForSize = new int[arraySize];


        }
    }
}
