class Employee
{
    private string firstName;
    private string lastName;
    private decimal monthlySalary;

    public Employee() : this("Kevin", "G", 1232.00M) { }

    public Employee(string firstName, string lastName, decimal monthlySalary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.MonthlySalary = monthlySalary;
    }

    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public decimal MonthlySalary
    {
        get => monthlySalary;
        set
        {
            if (value > 0)
                monthlySalary = value;
        }
    }

    public decimal YearlySalary()
    {
        return (12 * monthlySalary);
    }

    public void GiveRaise()
    {
        monthlySalary += (monthlySalary * 0.10M);
    }
}