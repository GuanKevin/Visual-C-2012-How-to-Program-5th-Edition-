using System;

/**
 * 7.38 (Find the Error) 
 * Find the error in the following recursive method, and explain how to correct it:
 */ 
namespace CHP07PE38
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Sum(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + Sum(n);
        }
    }
}
