using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 10.4 (Modifying the Internal Data Representation of a Class) 
 * It would be perfectly reasonable for the Time2 class of Fig. 10.5 to represent the time internally as the number 
 * of seconds since midnight rather than the three integer values hour, minute and second. Clients could use the same public 
 * methods and properties to get the same results. Modify the Time2 class of Fig. 10.5 to implement the Time2 as the 
 * number of seconds since midnight and show that no change is visible to the clients of the class by using the same test app 
 * from Fig. 10.6.
 */
namespace CHP10PE04
{
    class CustomTime
    {
        private int hour;
        private int minute;
        private int second;

        /**
         * Constructor that defaults to 0 if user does not fill in input
         * for the hour, minute and second to set the time
         */
        public CustomTime(int hour = 0, int minute = 0, int second = 0)
        {
            SetTime(hour, minute, second);
        }

        /**
         * Takes in the CustomTime object and use the objects time to 
         * instantiate a object with the same time from the object
         */
        public CustomTime(CustomTime customTime) : this(customTime.Hour, customTime.Minute, customTime.Second) { }

        /**
         * Sete a new time
         */
        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        /**
         * Set and Get the hours
         * Ensure that it has valid universal hours
         */
        public int Hour
        {
            get => hour;
            set
            {
                if (value >= 0 && value < 24)
                    hour = value;
                else
                    throw new ArgumentOutOfRangeException(
                        "Hour:", value, "\nHours must be between 0-23!"
                        );
            }
        }

        /**
         * Get and Set the minutes
         * Ensure that it has valid universal minuntes
         */
        public int Minute
        {
            get => minute;
            set
            {
                if (value >= 0 && value < 60)
                    minute = value;
                else
                    throw new ArgumentOutOfRangeException(
                        "Minute:", value, "\nMinutes must be between 0-60!"
                        );
            }
        }

        /**
         * Get and Set the seconds
         * Ensure that it has valid univeresal seconds
         */
        public int Second
        {
            get => second;
            set
            {
                if (value >= 0 && value < 60)
                    second = value;
                else
                    throw new ArgumentOutOfRangeException(
                        "Second:", value, "\nSeconds must be between 0-60!"
                        );
            }
        }

        /**
         * NEW UNRELATED CODE
         * TODO: CALL THIS IN TOSTRING AND TOUNIVERSALSTRING METHODS
         * Modify the Time2 class of Fig. 10.5 to implement the Time2 as the number of seconds 
         * since midnight and show that no change is visible to the clients of the class by using 
         * the same test app from Fig. 10.6.
         */
        public int SecondSinceMidnight()
        {
            int secondSinceMidnight = Second;
            secondSinceMidnight += (Minute * 60);
            secondSinceMidnight += (Hour * 60 * 60);

            return secondSinceMidnight;
        }

        /**
         * Convert hour, minute, second variables to string format
         */
        public String ToUniversalString()
        {
            return string.Format(
                "{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second
                );
        }

        /**
         * Convert to string in standard-time format (H:MM:SS AM or PM)
         */
        public override string ToString()
        {
            return string.Format("{0}:{1:D2}:{2:D2} {3}",
                ((Hour == 0 || Hour == 12) ? 12 : Hour % 12),
                Minute, Second, (Hour < 12 ? "AM" : "PM"));
        }

        static void Main(string[] args)
        {
            CustomTime t1 = new CustomTime(); // 00:00:00
            CustomTime t2 = new CustomTime(2); // 02:00:00
            CustomTime t3 = new CustomTime(21, 34); // 21:34:00
            CustomTime t4 = new CustomTime(12, 25, 42); // 12:25:42
            CustomTime t5 = new CustomTime(t4); // 12:25:42
            CustomTime t6;

            Console.WriteLine("Constructed with:\n");
            Console.WriteLine("t1: all arguments defaulted");
            Console.WriteLine(" {0}", t1.ToUniversalString()); // 00:00:00
            Console.WriteLine(" {0}\n", t1.ToString()); // 12:00:00 AM
            Console.WriteLine("t2: hour specified; minute and second defaulted");
            Console.WriteLine(" {0}", t2.ToUniversalString()); // 02:00:00
            Console.WriteLine(" {0}\n", t2.ToString()); // 2:00:00 AM
            Console.WriteLine("t3: hour and minute specified; second defaulted");
            Console.WriteLine(" {0}", t3.ToUniversalString()); // 21:34:00
            Console.WriteLine(" {0}\n", t3.ToString()); // 9:34:00 PM
            Console.WriteLine("t4: hour, minute and second specified");
            Console.WriteLine(" {0}", t4.ToUniversalString()); // 12:25:42
            Console.WriteLine(" {0}\n", t4.ToString()); // 12:25:42 PM
            Console.WriteLine("t5: Time2 object t4 specified");
            Console.WriteLine(" {0}", t5.ToUniversalString()); // 12:25:42
            Console.WriteLine(" {0}", t5.ToString()); // 12:25:42 PM
            // attempt to initialize t6 with invalid values 
            try
            {
                t6 = new CustomTime(27, 74, 99); // invalid values
            } // end try
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\nException while initializing t6:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
