﻿using System;

/**
 * 5.19 (Sales Commission Calculator) 
 * A large company pays its salespeople on a commission basis. The salespeople receive $200 per week plus 9% of their 
 * gross sales for that week. For example, a salesperson who sells $5,000 worth of merchandise in a week receives $200 
 * plus 9% of $5,000, or a total of $650. You’ve been supplied with a list of the items sold by each salesperson. The 
 * values of these items are as follows: 
 * Item Value 
 * 1. 239.99
 * 2. 129.75 
 * 3. 99.95
 * 4. 350.89 
 * Develop a C# app that inputs one salesperson’s items sold for the last week, then calculates and displays that 
 * salesperson's earnings. There’s no limit to the number of items that can be sold by a salesperson.
 */
namespace CHP05PE19
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sales = 0;

            Console.Write("Enter the item sold: ");
            int itemNumber = Convert.ToInt32(Console.ReadLine());
            

            while (itemNumber > 0 && itemNumber < 5)
            {
                if (itemNumber == 1)
                    sales += 239.99M;
                else if (itemNumber == 2)
                    sales += 129.76M;
                else if (itemNumber == 3)
                    sales += 99.95M;
                else if (itemNumber == 4)
                    sales += 350.89M;

                Console.Write("Enter the item sold: ");
                itemNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The salesperson sold {0:C} amount of merchandise!", sales);
            Console.WriteLine("The salesperson made {0:C}", (200 + (sales * 0.09M)));
        }
    }
}
