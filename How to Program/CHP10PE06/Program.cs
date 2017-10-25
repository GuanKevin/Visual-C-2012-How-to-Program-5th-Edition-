using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 10.6 (Enhancing Class Date) 
 * Modify class Date of Fig. 10.7 to perform error checking on the initializer values for instance variables month, 
 * day and year (class Date currently validates only the month and day). You’ll need to convert the auto-implemented 
 * property Year into instance variable year with an associated Year property. Provide method NextDay to increment 
 * the day by 1. The Date object should always maintain valid data and throw exceptions when attempts are made to 
 * set invalid values. Write an app that tests the NextDay method in a loop that displays the date during each iteration 
 * of the loop to illustrate that the NextDay method works correctly. Test the following cases: 
 * a) incrementing to the next month and 
 * b) incrementing to the next year.
 */ 
namespace CHP10PE06
{
    class Date
    {
        private int month; // 1 - 12
        private int day; // 1 - 31 based on month

        public Date(int theMonth, int theDay, int theYear)
        {
            Month = theMonth;
            Day= theDay;
            Year = theYear;
            Console.WriteLine("Date object constructor for date {0}", this);
        }

        // auto implemented property Year
        public int Year { get; private set; }

        public int Month {
            get => month;
            private set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException("Month", value, "Month must be 1 - 12");
            }
        }

        public int Day
        {
            get => day;
            private set
            {
                int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (value > 0 && value < daysPerMonth[Month])
                    day = value;
                else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                    day = value;
                else
                    throw new ArgumentOutOfRangeException("Day", value, "Day out of range for current month/year");
            }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Month, Day, Year);
        }

        static void Main(string[] args)
        {
        }
    }
}
