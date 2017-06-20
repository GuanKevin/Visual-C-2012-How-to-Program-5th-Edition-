class Employee
{
    private int hoursWorked;
    private decimal hourlyRate;

    public Employee() : this(40, 12.0M) { }

    public Employee(int hoursWorked, decimal hourlyRate)
    {
        this.HoursWorked = hoursWorked;
        this.HourlyRate = hourlyRate;
    }

    public decimal CalculatePay()
    {
        if (hoursWorked <= 40)
            return (hoursWorked * hourlyRate);
        else
            return (40 * hourlyRate) + ((hoursWorked - 40) * (hourlyRate * 1.5M));
    }

    public int HoursWorked { get => hoursWorked; set => hoursWorked = value; }
    public decimal HourlyRate { get => hourlyRate; set => hourlyRate = value; }
}