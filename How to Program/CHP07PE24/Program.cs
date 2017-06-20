using System;

/**
 * 7.24 (Perfect Numbers) 
 * An integer number is said to be a perfect number if its factors, including 1 (but not the number itself), sum to the 
 * number. For example, 6 is a perfect number, because 6 = 1 + 2 + 3. Write method Perfect that determines whether 
 * parameter value is a perfect number. Use this method in an app that determines and displays all the perfect numbers 
 * between 2 and 1000. Display the factors of each perfect number to confirm that the number is indeed perfect.
 */ 
namespace CHP07PE24
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
                if (IsPerfectNumber(i))
                    Console.WriteLine(i + " is a perfect number!");
        }

        public static Boolean IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
                if (number % i == 0)
                    sum += i;

            if (sum == number)
                return true;

            return false;
        }
    }
}
