using System;

/**
 * 7.37 (What Does This Code Do?) 
 * What does the following method do?
 */ 
namespace CHP07PE37
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // Parameter b must be positive to prevent infinite recursion
        public static int Mystery(int a, int b)
        {
            if (b == 1)
                return a;
            else
                return a + Mystery(a, b - 1);
        }
    }
}
