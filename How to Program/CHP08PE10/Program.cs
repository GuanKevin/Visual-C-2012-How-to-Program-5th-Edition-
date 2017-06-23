using System;

/**
 * 8.10 (Sales Commissions) 
 * Use a one-dimensional array to solve the following problem: A company pays its salespeople on a commission basis. 
 * The salespeople receive $200 per week plus 9% of their gross sales for that week. For example, a salesperson who grosses 
 * $5000 in sales in a week receives $200 plus 9% of $5000, or a total of $650. Write an app (using an array of counters) that 
 * determines how many of the salespeople earned salaries in each of the following ranges (assume that each salesperson’s salary 
 * is an integer). Summarize the results in tabular format. 
 * a) $200–299
 * b) $300–399 
 * c) $400–499 
 * d) $500–599 
 * e) $600–699
 * f) $700–799
 * g) $800–899
 * h) $900–999
 * i) $1000 and over
 */ 
namespace CHP08PE10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commissions = { 5700, 1000, 1500, 1100, 9500,
                                    5060, 7070, 0, 8100, 8500,
                                        3300, 7460, 1500, 5450, 3200,
                                            5500, 1500, 3670, 1900, 10050,
                                               21300, 6700, 4900, 7130, 1200 };

            SalesCommission sc = new SalesCommission(commissions);
            sc.ProcessSalesCommission();
        }
    }
}
