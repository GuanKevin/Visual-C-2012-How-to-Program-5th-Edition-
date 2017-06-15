using System;

/**
 * 5.25 (What Does This Program Do?) 
 * What does the following app display?
 */ 
namespace CHP05PE25
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine(count % 2 == 1 ? "****" : "++++++++");
                ++count;
            } // end while
        }
    }
}
