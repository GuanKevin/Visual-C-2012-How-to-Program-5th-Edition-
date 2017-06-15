using System;

/**
 * 6.21 (Pythagorean Triples) 
 * A right triangle can have sides whose lengths are all integers. The set of three integer values for the lengths of the 
 * sides of a right triangle is called a Pythagorean triple (en.wikipedia.org/wiki/Pythagorean_triple). The lengths of the 
 * three sides must satisfy the relationship that the sum of the squares of two of the sides is equal to the square of the 
 * hypotenuse. Write an app to find all Pythagorean triples for side1, side2 and the hypotenuse, all no larger than 500. 
 * Use a triple-nested for loop that tries all possibilities. This method is an example of “bruteforce” computing. You’ll 
 * learn in more advanced computer science courses that there are many interesting problems for which there’s no known 
 * algorithmic approach other than using sheer brute force.
 */ 
namespace CHP06PE21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Side1{0, 10}{1, 10}", "Side2", "Side3");
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    for (int k = i; k <= 100; k++)
                    {
                        if ((Math.Pow(i, 2) + (Math.Pow(j, 2)) == Math.Pow(k, 2)))
                            Console.WriteLine("{0}{1, 14}{2, 10}", i, j, k);
                    }
                }
            }
        }
    }
}
