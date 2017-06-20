using System;

/**
 * 7.28 (Converting Grade Averages to a Four-Point Scale) 
 * Write method QualityPoints that inputs a student’s average and returns 4 if the student's average is 90–100, 3 if 
 * the average is 80–89, 2 if the average is 70–79, 1 if the average is 60–69 and 0 if the average is lower than 60. 
 * Incorporate the method into an app that reads a value from the user and displays the result.
 */ 
namespace CHP07PE28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade to find your GPA: ");
            Console.WriteLine("Your GPA is {0}!", QualityPoints(Convert.ToInt32(Console.ReadLine())));   
        }

        public static int QualityPoints(int grade)
        {
            if (grade >= 90)
                return 4;
            else if (grade >= 80)
                return 3;
            else if (grade >= 70)
                return 2;
            else if (grade >= 60)
                return 1;
            else
                return 0;
        }
    }
}
