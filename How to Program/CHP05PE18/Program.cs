using System;

/**
 * 5.18 (Credit Limit Calculator) 
 * Develop a C# app that will determine whether any of several department store customers has exceeded the credit limit 
 * on a charge account. For each customer, the following facts are available: 
 * a) account number 
 * b) balance at the beginning of the month
 * c) total of all items charged by the customer this month
 * d) total of all credits applied to the customer’s account this month
 * e) allowed credit limit.
 * The app should input all these facts as integers, calculate the new balance (= beginning balance + charges – credits), 
 * display the new balance and determine whether the new balance exceeds the customer’s credit limit. For those customers 
 * whose credit limit is exceeded, the app should display the message "Credit limit exceeded". Use sentinel-controlled 
 * repetition to obtain the data for each account.
 */
namespace CHP05PE18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Check your account (Y|N): ");
            char checkAccount = Char.ToUpper(Convert.ToChar(Console.Read()));
            Console.ReadLine();

            while (checkAccount == 'Y')
            {
                Console.Write("Enter your account number: ");
                int accountNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your balance: ");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter total of all items charged: ");
                decimal totalItemsCharges = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter all credits applied: ");
                decimal credits = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter credit limit: ");
                int creditLimit = Convert.ToInt32(Console.ReadLine());

                if (new CreditCard(accountNumber, balance, totalItemsCharges, credits, creditLimit).CurrentBalance())
                    Console.WriteLine("Credit limit exceeded");

                Console.Write("Check your account (Y|N): ");
                checkAccount = Char.ToUpper(Convert.ToChar(Console.Read()));
                Console.ReadLine();
            }
        }
    }
}
