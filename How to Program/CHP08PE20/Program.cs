using System;

/**
 * 8.20 (Total Sales) 
 * Use a rectangular array to solve the following problem: A company has three salespeople (1 to 3) who sell five different 
 * products (1 to 5). Once a day, each salesperson passes in a slip for each type of product sold. Each slip contains the 
 * following: 
 * a) The salesperson number 
 * b) The product number
 * c) The total dollar value of that product sold that day
 * Thus, each salesperson passes in between 0 and 5 sales slips per day. Assume that the information from all of the slips for 
 * last month is available.Write an app that will read all the information for last month’s sales and summarize the total sales 
 * by salesperson and by product. All totals should be stored in rectangular array sales. After processing all the information 
 * for last month, display the results in tabular format, with each column representing a particular salesperson and each row 
 * representing a particular product. Cross-total each row to get the total sales of each product for last month. Crosstotal 
 * each column to get the total sales by salesperson for last month. Your tabular output should include these cross-totals to 
 * the right of the totaled rows and below the totaled columns.
 */
namespace CHP08PE20
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] recArray = { { 100, 200, 300},
                                    { 100, 200, 300 },
                                      { 100, 200, 300 },
                                        { 100, 200, 300 },
                                          { 100, 200, 300 } };

            Console.WriteLine("{0}{1,10}{2,10}{3,10}{4,10}", "Sales","0001","0002","0003", "Total");
            for (int i = 0; i < recArray.GetLength(0); i++)
            {
                Console.Write("    ");
                double sum = 0;
                for (int j = 0; j < recArray.GetLength(1); j++)
                {
                    Console.Write("{0, 10}", recArray[i, j]);
                    
                    sum += recArray[i, j];
                }

                Console.WriteLine("{0,10}", sum);
            }

            Console.Write("Total");

            for (int i = 0; i < recArray.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < recArray.GetLength(0); j++)
                {
                    sum += recArray[j, i];
                }
                Console.Write("{0,10}", sum);
            }
            Console.WriteLine();
        }
    }
}
