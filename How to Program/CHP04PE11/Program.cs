using System;

/**
 * 4.11 (Account Modification) 
 * Modify class Account (Fig. 4.15) to provide a method called Debit that withdraws money from an Account. 
 * Ensure that the debit amount doesn’t exceed the balance. If it does, the balance should not be changed 
 * and the method should display a message indicating "Debit amount exceeded account balance." 
 */
namespace CHP04PE11
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(500);
            myAccount.Debit(501);        
            Console.WriteLine("My default balance is {0:C}!", myAccount.Balance);
        }
    }
}
