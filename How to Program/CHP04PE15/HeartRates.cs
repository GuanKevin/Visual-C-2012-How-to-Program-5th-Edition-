class HeartRates
{
    private string firstName;
    private string lastName;
    private int dateOfBirth;
    private int currentYear;

    public HeartRates() : this("Kevin", "G", 1992, 2017) { }

    public HeartRates(string firstName, string lastName, int dateOfBirth, int currentYear)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.DateOfBirth = dateOfBirth;
        this.CurrentYear = currentYear;
    }

    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    public int CurrentYear { get => currentYear; set => currentYear = value; }

    private int GetAge()
    {
        return (currentYear - dateOfBirth);
    }

    private int CalculateHeartRate()
    {
        return (220 - GetAge());
    }

    public double MinimumHeartRate()
    {
        return (CalculateHeartRate() / 2.0);
    }

    public double MaximumHeartRate()
    {
        return (CalculateHeartRate() * 0.85);
    }
}