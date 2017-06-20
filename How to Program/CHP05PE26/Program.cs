using System;

/**
 * 5.26 (What Does This Program Do?) 
 * What does the following app display?
 */ 
namespace CHP05PE26
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 10;
            int column;

            while (row >= 1)
            {
                column = 1;

                while (column <= 10)
                {
                    Console.Write(row % 2 == 1 ? "<" : ">");  
                    ++column;
                }

                --row;
                Console.WriteLine();
            }
        }
    }
}
