using System;

/**
 * 8.13 (Jagged Arrays) 
 * List the elements of the three-by-five jagged array sales in the order in which they’re set to 0 by the following code 
 * segment: 
 * for ( int row = 0; row < sales.Length; ++row )
 * {
 *  for ( int col = 0; col < sales[row].Length; ++col )
 *  {
 *      sales[ row ][ col ] = 0;
 *  }
 * }
 */ 
namespace CHP08PE13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] sales =
            {
                new int[] {3, 4, 5},
                new int[] {3, 4, 5, 6},
                new int[] {3, 4, 5, 6, 7}
            };

            for (int row = 0; row < sales.Length; ++row)
            {
                for (int col = 0; col < sales[row].Length; ++col)
                {
                    Console.Write(sales[row][col] + " ");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < sales.Length; ++row)
            {
               for (int col = 0; col < sales[row].Length; ++col)
               {
                    sales[row][col] = 0;
               }
            }

            for (int row = 0; row < sales.Length; ++row)
            {
                for (int col = 0; col < sales[row].Length; ++col)
                {
                    Console.Write(sales[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
