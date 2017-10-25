using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 10.5 (Savings-Account Class) 
 * Create the class SavingsAccount. Use the static variable annualInterestRate to store the annual interest rate for 
 * all account holders. Each object of the class contains a private instance variable savingsBalance, indicating 
 * the amount the saver currently has on deposit. Provide method CalculateMonthlyInterest to calculate the monthly 
 * interest by multiplying the savingsBalance by annualInterestRate divided by 12—this interest should be added to 
 * savingsBalance. Provide static method ModifyInterestRate to set the annualInterestRate to a new value. Write an 
 * app to test class SavingsAccount. Create two savingsAccount objects, saver1 and saver2, with balances of $2000.00
 * and $3000.00, respectively. Set annualInterestRate to 4%, then calculate the monthly interest and display the new 
 * balances for both savers. Then set the annualInterestRate to 5%, calculate the next month’s interest and display 
 * the new balances for both savers.
 */
namespace CHP10PE05
{
    class SavingsAccount
    {
        public static double annualInterestRate = 5;
        private double savingsBalance;

        /**
         * Calculate the monthly interest by multiplying the savingsBalance by annualInterestRate divided by 12
         * —this interest should be added to savingsBalance
         */ 
        public double CalculateMonthlyInterest()
        {
            double interestRate = savingsBalance * (annualInterestRate / 12.0);
            savingsBalance += interestRate;

            return interestRate;
        }

        public static void ModifyInterestRate(double annualInterestRate)
        {
            SavingsAccount.annualInterestRate = annualInterestRate;
        }

        static void Main(string[] args)
        {
        }
    }
}
