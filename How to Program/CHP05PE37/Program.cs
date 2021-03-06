﻿using System;

/**
 * 5.37 (Factorials)
 * The factorial of a nonnegative integer n is written as n! (pronounced “n factorial”) and is defined as follows:
 * n! = n · (n – 1) · (n – 2) ·…· 1 (for values of n greater than or equal to 1) and n! = 1 (for n = 0) 
 * For example, 5! = 5 · 4 · 3 · 2 · 1, which is 120. Write an app that reads a nonnegative integer and 
 * computes and displays its factorial.
 */ 
namespace CHP05PE37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int factorial = Convert.ToInt32(Console.ReadLine());
            int sum = 1;

            while (factorial > 0)
            {
                sum *= factorial--;
            }

            Console.WriteLine("The factorial is {0}.", sum);
        }
    }
}
