using System;

/**
 * 5.28 (Another Dangling-else Problem) 
 * Modify the given code to produce the output shown in each part of the problem. Use proper indentation techniques.
 * Make no changes other than inserting braces and changing the indentation of the code. The compiler ignores indentation 
 * in a C# app. We’ve eliminated the indentation from the given code to make the problem more challenging.
 * [Note: It’s possible that no modification is necessary for some of the parts.]
 */
namespace CHP05PE28
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 7,
                x = 5;

            if (y == 8)
            {
                if (x == 5)
                    Console.WriteLine("@@@@@");
            }
            else
            {
                Console.WriteLine("#####");
                Console.WriteLine("$$$$$");
                Console.WriteLine("&&&&&");
            }
           
                
            /*               
                a) Assuming that x = 5 and y = 8, the following output is produced:
                @@@@@
                $$$$$
                &&&&&
                b) Assuming that x = 5 and y = 8, the following output is produced:
                @@@@@
                c) Assuming that x = 5 and y = 8, the following output is produced:
                @@@@@
                &&&&&
                d) Assuming that x = 5 and y = 7, the following output is produced.
                #####
                $$$$$
                &&&&&
            */
        }
    }
}
