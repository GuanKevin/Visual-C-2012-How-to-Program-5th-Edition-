using System;

/**
 * 8.19 (Airline Reservations System) 
 * A small airline has just purchased a computer for its new automated reservations system. You have been asked to develop the 
 * new system. You’re to write an app to assign seats on each flight of the airline’s only plane (capacity: 10 seats). Display 
 * the following alternatives: Please type 1 for First Class and Please type 2 for Economy. If the user types 1, your app should 
 * assign a seat in the first-class section (seats 1–5). If the user types 2, your app should assign a seat in the economy 
 * section (seats 6–10). Use a one-dimensional array of type bool to represent the seating chart of the plane. Initialize all 
 * the elements of the array to false to indicate that all the seats are empty. As each seat is assigned, set the corresponding 
 * element of the array to true to indicate that the seat is no longer available. Your app should never assign a seat that has 
 * already been assigned. When the economy section is full, your app should ask the person if it’s acceptable to be placed in 
 * the first-class section (and vice versa). If yes, make the appropriate seat assignment. If no, display the message "Next 
 * flight leaves in 3 hours."
 */ 
namespace CHP08PE19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] airlineReservationSystemArray = new bool[10];
            Console.WriteLine("Please type 1 for First Class and Please type 2 for Economy");
            byte assignSeats;

            while (SeatsAvailable(airlineReservationSystemArray))
            {
                Console.Write("Assign to: ");
                assignSeats = Convert.ToByte(Console.ReadLine());

                if (assignSeats == 1)
                {
                    // Assign the passenger to the next available first class seat
                    if (SeatsAvailable(airlineReservationSystemArray, 0, 5))                    
                        AssignSeats(airlineReservationSystemArray, 0, 5);
                    else
                    {
                        Console.Write("Is it acceptable to be placed in economy section [Y/N]: ");
                        char input = char.ToUpper(Convert.ToChar(Console.Read()));

                        if (input == 'Y')
                            AssignSeats(airlineReservationSystemArray, 5, 10);
                        else
                            Console.WriteLine("Next flight leaves in 3 hours.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    // Assign the passenger to the next available economy seat
                    if (SeatsAvailable(airlineReservationSystemArray, 5, 10))
                        AssignSeats(airlineReservationSystemArray, 5, 10);
                    else
                    {
                        Console.Write("Is it acceptable to be placed in first class section [Y/N]: ");
                        char input = char.ToUpper(Convert.ToChar(Console.Read()));

                        if (input == 'Y')
                            AssignSeats(airlineReservationSystemArray, 0, 5);
                        else
                            Console.WriteLine("Next flight leaves in 3 hours.");
                        Console.ReadLine();
                    }
                }

                DisplayPlaneSeats(airlineReservationSystemArray);
            }
            Console.WriteLine("Next flight leaves in 3 hours.");
        }

        public static void DisplayPlaneSeats(bool[] airlineReservationSystemArray)
        {
            for (int i = 0; i < airlineReservationSystemArray.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                    Console.WriteLine("[{0}]", (airlineReservationSystemArray[i] ? "*" : " "));
                else
                    Console.Write("[{0}]", (airlineReservationSystemArray[i] ? "*" : " "));
            }
        }

        public static void AssignSeats(bool[] airlineReservationSystemArray, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (airlineReservationSystemArray[i] == false)
                {
                    airlineReservationSystemArray[i] = true;
                    return;
                }
            }
        }

        /**
         * Checks if there are seats still available on the plane
         */ 
        public static bool SeatsAvailable(bool[] airlineReversationSystemArray, int start = 0, int end = 10)
        {
            for (int i = start; i < end; i++)
                if (airlineReversationSystemArray[i] == false)
                    return true;

            return false;
        }
    }
}
