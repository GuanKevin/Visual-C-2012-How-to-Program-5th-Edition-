using System;

/**
 * 5.24 (Validating User Input) 
 * Modify the app in Fig. 5.12 to validate its inputs. For any input, if the value entered is other than 1 or 2, 
 * display the message “Invalid input,” then keep looping until the user enters a correct value.
 */ 
namespace CHP05PE24
{
    class Program
    {
        static void Main(string[] args)
        {
            int passes = 0;
            int failures = 0;
            int studentCounter = 1;
            int result;

            while (studentCounter <= 10)
            {
                Console.Write("Enter result (1 = pass, 2 = fail: ");
                result = Convert.ToInt32(Console.ReadLine());

                if (result == 1)
                    passes = passes + 1;
                else 
                    failures = failures + 1;
            }

            Console.WriteLine("Passed: {0}\nFailed: {1}", passes, failures);

            if (passes > 8)
                Console.WriteLine("Bonus to instructor!");
        }
    }
}
