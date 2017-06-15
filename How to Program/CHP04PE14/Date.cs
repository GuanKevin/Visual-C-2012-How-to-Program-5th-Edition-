using System;

class Date
{
    private int month;
    private int day;
    private int year;

    public Date() : this(7, 14, 2017) { }

    public Date(int month, int day, int year)
    {
        this.Month = month;
        this.Day = day;
        this.Year = year;
    }

    public int Month { get => month; set => month = value; }
    public int Day { get => day; set => day = value; }
    public int Year { get => year; set => year = value; }

    public string DisplayDate()
    {
        return (month + "/" + day + "/" + year);
    }
}