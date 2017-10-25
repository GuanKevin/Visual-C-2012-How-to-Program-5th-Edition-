using System;

/**
 * 8.19 (Airline Reservations System) 
 * A small airline has just purchased a computer for its new automated reservations system. 
 * You have been asked to develop the new system. You’re to write an app to assign seats on each flight of the 
 * airline’s only plane (capacity: 10 seats). Display the following alternatives: 
 * Please type 1 for First Class and Please type 2 for Economy. 
 * If the user types 1, your app should assign a seat in the first-class section (seats 1–5). 
 * If the user types 2, your app should assign a seat in the economy section (seats 6–10). 
 * Use a one-dimensional array of type bool to represent the seating chart of the plane. 
 * Initialize all the elements of the array to false to indicate that all the seats are empty. 
 * As each seat is assigned, set the corresponding element of the array to true to indicate that the seat 
 * is no longer available. Your app should never assign a seat that has already been assigned. When the economy 
 * section is full, your app should ask the person if it’s acceptable to be placed in the first-class section (and vice versa). If yes, make the appropriate seat assignment. If no, display the message "Next 
 * flight leaves in 3 hours."
 */ 
namespace CHP08PE19
{
    class AirlineReservationSystem
    {
        // Number of available seats
        private const int CAPACITY = 10;
        // index 0 for first-class, index 1 for economy class
        private Boolean[] section = new Boolean[2];
        private Boolean[] seats;

        public AirlineReservationSystem()
        {
            seats = new Boolean[CAPACITY];
            DisplayMessage();
            ReserveSeats();
        }

        /**
         * Choose from a list of available seats
         */
        private void ReserveSeats()
        {
            DisplayAvailableSeats();
        }

        /**
         * Display a list of available seats
         * If no seats are available then end program, 
         * if the requested section seats are unavailable, 
         * see if user is willing to switch section
         */ 
        private void DisplayAvailableSeats()
        {
            bool isAvailable = false;
            int start = (section[0] == true ? 0 : 5);
            int capacity = start + 5;

            Console.Write("Available seats: ");
            for (; start < capacity;)
            {
                if (seats[start++] == false)
                {
                    Console.Write(start + " ");
                    isAvailable = true;
                }
            }

            Console.WriteLine();

            if (!isAvailable)
            {
                Console.WriteLine("Would you like to switch to " + (section[0] == true ? "first-class?" : "economy?"));
                Console.Write("[Y/N]: ");
                char userInput = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.WriteLine(userInput);
            }
        }

        /**
         * Shows user the options in picking seats
         */ 
        private void DisplayMessage()
        {
            Console.WriteLine("-----------------------------------------" +
                            "\n| Enter 1 to choose a first class seat. |" +
                            "\n| Enter 2 to choose a econ class seat.  |" +
                            "\n-----------------------------------------");

            Console.Write("Enter section: ");
            int section = Convert.ToInt32(Console.ReadLine());
            this.section[section - 1] = true;
        }

        public static void Main(String[] args)
        {
            AirlineReservationSystem reverseSeat = new AirlineReservationSystem();
            Console.ReadLine();
        }
    }
}
