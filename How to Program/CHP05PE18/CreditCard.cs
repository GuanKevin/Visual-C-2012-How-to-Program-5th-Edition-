using System;

class CreditCard
{
    private int accountNumber;
    private decimal monthlyBalance;
    private decimal totalCharge;
    private decimal creditApplied;
    private int creditLimit;

    public CreditCard() : this(10001, 823.45M, 1567.98M, 500M, 1000) { }

    public CreditCard(int accountNumber, decimal monthlyBalance, decimal totalCharge, decimal creditApplied, int creditLimit)
    {
        this.AccountNumber = accountNumber;
        this.MonthlyBalance = monthlyBalance;
        this.TotalCharge = totalCharge;
        this.CreditApplied = creditApplied;
        this.CreditLimit = creditLimit;
    }

    public Boolean CurrentBalance()
    {
        if ((monthlyBalance + totalCharge - creditApplied) > creditLimit)
            return true;
        else
            return false;
    }

    public int AccountNumber { get => accountNumber; set => accountNumber = value; }
    public decimal MonthlyBalance { get => monthlyBalance; set => monthlyBalance = value; }
    public decimal TotalCharge { get => totalCharge; set => totalCharge = value; }
    public decimal CreditApplied { get => creditApplied; set => creditApplied = value; }
    public int CreditLimit { get => creditLimit; set => creditLimit = value; }
}