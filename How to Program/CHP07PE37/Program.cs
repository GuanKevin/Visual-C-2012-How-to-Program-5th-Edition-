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
            Console.WriteLine("Mystery: {0}", Mystery(3, 4));
        }
        // a = 3;
        // b = 4
        // 3 + (
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
