using System;

class HealthProfile
{
    private string firtName;
    private string lastName;
    private char gender;
    private int month;
    private int day;
    private int year;
    private int heightInInches;
    private int weightInPounds;

    public HealthProfile() : this("Kevin", "G", 'C', 7, 14, 2007, 70, 150) { }

    public HealthProfile(string firtName, string lastName, char gender, int month, int day, int year, int heightInInches, int weightInPounds)
    {
        this.FirtName = firtName;
        this.LastName = lastName;
        this.Gender = gender;
        this.Month = month;
        this.Day = day;
        this.Year = year;
        this.HeightInInches = heightInInches;
        this.WeightInPounds = weightInPounds;
    }

    private int GetAge()
    {
        return (2017 - year);
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

    public int GetBMI()
    {
        int bmi = (int)((weightInPounds * 703) / (Math.Pow(heightInInches, 2)));

        Console.WriteLine("\nBMI range:" +
            "\nUnderweight: less than 18.5" +
            "\nNormal: between 18.5 and 24.9" +
            "\nOverweight: between 25 and 29.9" +
            "\nObese: 30 or greater");

        return bmi;
    }

    public string FirtName { get => firtName; set => firtName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public char Gender { get => gender; set => gender = value; }
    public int Month { get => month; set => month = value; }
    public int Day { get => day; set => day = value; }
    public int Year { get => year; set => year = value; }
    public int HeightInInches { get => heightInInches; set => heightInInches = value; }
    public int WeightInPounds { get => weightInPounds; set => weightInPounds = value; }
}