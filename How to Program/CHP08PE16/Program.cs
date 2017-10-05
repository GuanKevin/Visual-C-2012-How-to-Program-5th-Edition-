using System;

/**
 * 8.16 (Using the foreach Statement) 
 * Write an app that uses a foreach statement to sum the double values passed by the command-line arguments. 
 * [Hint: Use static method ToDouble of class Convert to convert a string to a double value.]
 */ 
namespace CHP08PE16
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Command-Line arguments is empty!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Command-Line arguments found, proceeding to evaulating values....");

                double sum = 0;
                int counter = 0;

                foreach (string number in args)
                {
                    if (counter++ < (args.Length - 1))
                        Console.Write(number + " + ");
                    else
                        Console.Write(number + " = ");

                    try
                    {
                        sum += Convert.ToDouble(number);
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine("SOMEONE DIDNT PUT IN DOUBLE VALUES INSIDE THE COMMAND LINE ARGUMENTS!!!!!");
                        Console.WriteLine(fe.Message);
                    }
                }

                Console.WriteLine(sum);
            }            
        }
    }
}
