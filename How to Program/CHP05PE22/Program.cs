using System;

/**
 * 5.22 (Tabular Output) 
 * Write a C# app that uses looping to display the following table of values:
 * N 10*N 100*N 1000*N
 * 1 10   100   1000
 * 2 20   200   2000
 * 3 30   300   3000
 * 4 40   400   4000
 * 5 50   500   5000
 */
namespace CHP05PE22
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("N\t10*N\t100*N\t1000*N");

            while (counter++ < 5)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", (counter), (counter * 10), (counter * 100), (counter * 1000));
            }
        }
    }
}
