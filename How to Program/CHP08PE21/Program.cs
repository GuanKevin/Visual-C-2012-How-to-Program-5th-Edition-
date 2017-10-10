using System;

/**
 * 8.21 (Turtle Graphics) 
 * The Logo language made the concept of turtle graphics famous. Imagine a mechanical turtle that walks around the room under 
 * the control of a C# app. The turtle holds a pen in one of two positions—up or down. While the pen is down, the turtle traces 
 * out shapes as it moves, and while the pen is up, the turtle moves about freely without writing anything. In this problem, 
 * you’ll simulate the operation of the turtle and create a computerized sketchpad. Use a 20-by-20 rectangular array floor 
 * that’s initialized to 0. Read commands from an array that contains them. Keep track at all times of the current position of 
 * the turtle and whether the pen is currently up or down. Assume that the turtle always starts at position (0, 0) of the floor 
 * with its pen up. The set of turtle commands your app must process are shown in Fig. 8.25. Suppose that the turtle is 
 * somewhere near the center of the floor. The following “app” would draw and display a 12-by-12 square, leaving the pen in 
 * the up position: (SEE BOOK)
 * As the turtle moves with the pen down, set the appropriate elements of array floor to 1s.When the 6 command (display the 
 * array) is given, wherever there’s a 1 in the array, display an asterisk or any character you choose. Wherever there’s a 0, 
 * display a blank. Write an app to implement the turtle graphics capabilities discussed here. Write several turtle graphics 
 * apps to draw interesting shapes. Add other commands to increase the power of your turtle graphics language.
 */ 
namespace CHP08PE21
{
    class TurtleGraphics
    {
        private int[] commands;
        private String[,] instruction = new String[,] {
            { "1", "Pen Up" },
            { "2", "Pen Down" },
            { "3", "Turn Right" },
            { "4", "Turn Left" },
            { "5", "Move forward X spaces" },
            { "6", "Display Map" },
            { "9", "End run" }
        };
        

        public TurtleGraphics()
        {
            commands = new int[] { 2, 5, 3, 5, 3, 5, 3, 5, 1, 6, 9 };
            DislplayMessage();
        }

        public TurtleGraphics(int[] commands)
        {
            this.commands = commands;
            DislplayMessage();
        }

        private void DislplayMessage()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("{0, -10}{1, 10}", "Command", "Meaning");

            for (int i = 0; i < instruction.GetLength(0); i++)
            {
                Console.WriteLine("{0, -7}{1, 10}", instruction[i, 0], instruction[i, 1]);
            }

        }

        static void Main(string[] args)
        {
            TurtleGraphics tg = new TurtleGraphics();
        }
    }
}
