using System;

class Account
{
    private decimal balance;

    public Account() : this(1000.0M) { }

    public Account(decimal balance)
    {
        this.balance = balance;
    }

    public decimal Balance { get => balance; set => balance = value; }

    public void Credit(decimal credit)
    {
        Balance += credit;
    }

    public void Debit(decimal withdraw)
    {
        if (withdraw <= Balance)
            Balance -= withdraw;
        else
            Console.WriteLine("Debit amount exceeded account balance");
    }
}