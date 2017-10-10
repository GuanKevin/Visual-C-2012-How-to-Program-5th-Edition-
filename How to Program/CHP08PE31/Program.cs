using System;
using System.Threading;

/**
 * 8.31 (Machine-Language Programming) Let’s create a computer called the Simpletron. 
 * As its name implies, it’s a simple machine, but powerful. The Simpletron runs programs written in the only language 
 * it directly understands: Simpletron Machine Language, or SML for short. The Simpletron contains an accumulator—a special 
 * register into which information is put before the Simpletron uses it in calculations or examines it in various ways. 
 * All the information in the Simpletron is handled in terms of words. 
 * 
 * A word is a signed four-digit decimal number, such as +3364, -1293, +0007 and -0001. 
 * 
 * The Simpletron is equipped with a 100-word memory, and these words are referenced by their location numbers 00, 01,…, 99. 
 * 
 * Before running an SML program, we must load, or place, the code into memory. The first instruction 
 * (or statement) of every SML program is always placed in location 00. The simulator will start executing at this location.
 * Each instruction written in SML occupies one word of the Simpletron’s memory (hence, instructions are signed four-digit decimal numbers).
 * We shall assume that the sign of an SML instruction is always plus, but the sign of a data word may be either plus or minus. 
 * Each location in the Simpletron’s memory may contain an instruction, a data value used by a program or an unused (and hence undefined) 
 * area of memory. 
 * 
 * The first two digits of each SML instruction are the operation code specifying the operation to be performed. 
 * The last two digits of an SML instruction are the operand—the address of the memory location containing the word to which 
 * the operation applies. 
 * 
 * Let’s consider several simple SML programs. 
 * The first SML program (Fig. 8.30) reads two numbers from the keyboard, then computes and displays their sum. 
 * The instruction +1007 reads the first number from the keyboard and places it into location 07 (which has been initialized to 0). 
 * Then instruction +1008 reads the next number into location 08. The load instruction, +2007, puts the first number into the accumulator, 
 * and the add instruction, +3008, adds the second number to the number in the accumulator. All SML arithmetic instructions leave their 
 * results in the accumulator. The store instruction, +2109, places the result in memory location 09, from which the write instruction, 
 * +1109, takes the number and displays it (as a signed four-digit decimal number). The halt instruction, +4300, terminates execution. 
 * The second SML program (Fig. 8.31) reads two numbers from the keyboard and determines and displays the larger value. 
 * Note the use of the instruction +4107 as a conditional transfer of control, much the same as C#’s if statement.
 * Now write SML programs to accomplish each of the following tasks: 
 *      a) Use a sentinel-controlled loop to read positive numbers and compute and display their sum. 
 *              Terminate input when a negative number is entered. 
 *      b) Use a counter-controlled loop to read seven numbers, some positive and some negative, 
 *              then compute and display their average.
 *      c) Read a series of numbers, then determine and display the largest number. 
 *              The first number read indicates how many numbers should be processed.
 */
namespace CHP08PE31
{
    class Simpletron
    {
        // The Simpletron is equipped with a 100-word memory
        // A word is a signed four-digit decimal number, such as +3364, -1293, +0007 and -0001. 
        const int SIZE = 100;
        private int accumulator = 0;
        private int[] memory = new int[SIZE];
        private int[] operationCodeList = new int[] { 10, 11, 20, 21, 30, 31, 32, 33, 40, 41, 42, 43 };
        private string[,] ioOperations = new string[,]{
            { "READ", "10", "Read a word from the keyboard into a specific location in memory." },
            { "WRITE", "11", "Write a word from a specific location in memory to the screen." },
            { "LOAD", "20", "Load a word from a specific location in memory into the accumulator." },
            { "STORE", "21", "Store a word from the accumulator into a specific location in memory." },
            { "ADD", "30", "Add a word from a specific location in memory to the word in the accumulator (leave the result in the accumulator)." },
            { "SUBTRACT", "31", "Subtract a word from a specific location in memory from the word in the accumulator (leave the result in the accumulator)." },
            { "DIVIDE", "32", "Divide a word from a specific location in memory into the word in the accumulator (leave result in the accumulator)." },
            { "MULTIPLY", "33", "Multiply a word from a specific location in memory by the word in the accumulator (leave the result in the accumulator)." },
            { "BRANCH", "40", "Branch to a specific location in memory." },
            { "BRANCHNEG", "41", "Branch to a specific location in memory if the accumulator is negative." },
            { "BRANCHZERO", "42", "Branch to a specific location in memory if the accumulator is zero." },
            { "HALT", "43", "Halt. The program has completed its task." }
        };

        public Simpletron()
        {
            DisplayOperationCode();
            LoadWordsToMemory();
            RunInstruction();
        }

        // Reads the register 
        private void RunInstruction()
        {
            for (int i = 0; i < memory.Length; i++)
            {
                int operationCode = int.Parse(memory[i].ToString().Substring(0, 2));

                if (operationCode == 43)
                    break;
                else
                {
                    char[] charArray = memory[i].ToString().ToCharArray();
                    int location = int.Parse("" + charArray[2] + charArray[3]);                    
                    Instruction(operationCode, location);
                }
            }

            Console.WriteLine("The result is {0}.", accumulator);
        }

        private void Instruction(int operationCode, int location)
        {
            switch (operationCode)
            {
                // "READ", "10", "Read a word from the keyboard into a specific location in memory."
                case 10:
                    Console.Write("Enter a number: ");
                    memory[location] = Convert.ToInt32(Console.ReadLine());
                    break;
                // "WRITE", "11", "Write a word from a specific location in memory to the screen."
                case 11:
                    Console.WriteLine("Writing... " + memory[location]);
                    Thread.Sleep(2000);
                    break;
                // "LOAD", "20", "Load a word from a specific location in memory into the accumulator."
                case 20:
                    accumulator = memory[location];
                    Console.WriteLine("Loading... " + accumulator);
                    Thread.Sleep(2000);
                    break;
                // "STORE", "21", "Store a word from the accumulator into a specific location in memory."
                case 21:
                    memory[location] = accumulator;
                    Console.WriteLine("Storing... " + accumulator);
                    Thread.Sleep(2000);
                    break;
                // "ADD", "30", "Add a word from a specific location in memory to the word in the accumulator 
                // (leave the result in the accumulator)."
                case 30:
                    Console.WriteLine("Adding {0} to {1}", memory[location], accumulator);
                    accumulator += memory[location];
                    Thread.Sleep(2000);
                    break;
                // "SUBTRACT", "31", "Subtract a word from a specific location in memory from the word in the accumulator 
                // (leave the result in the accumulator)."
                case 31:
                    Console.WriteLine("Subtracting {0} from {1}", memory[location], accumulator);
                    accumulator -= memory[location];
                    Thread.Sleep(2000);
                    break;
                // "DIVIDE", "32", "Divide a word from a specific location in memory into the word in the accumulator 
                // (leave result in the accumulator)."
                case 32:
                    Console.WriteLine("Dividing {0} by {1}", memory[location], accumulator);
                    accumulator /= memory[location];
                    break;
                // "MULTIPLY", "33", "Multiply a word from a specific location in memory by the word in the accumulator 
                // (leave the result in the accumulator)."
                case 33:
                    Console.WriteLine("Multiplying {0} with {1}", memory[location], accumulator);
                    accumulator *= memory[location];
                    Thread.Sleep(2000);
                    break;
                // "BRANCH", "40", "Branch to a specific location in memory."
                case 40:
                    if (accumulator != 0)
                        memory[location] = accumulator;
                    break;
                // "BRANCHNEG", "41", "Branch to a specific location in memory if the accumulator is negative."
                case 41:
                    if (accumulator < 0)
                    {
                        Console.WriteLine("Storing negative number to location {0}.", location);
                        memory[location] = accumulator;
                        Thread.Sleep(2000);
                    }
                    break;

                // "BRANCHZERO", "42", "Branch to a specific location in memory if the accumulator is zero."
                case 42:
                    if (accumulator >= 0)
                    {
                        Console.WriteLine("Storing positive number to location {0}.", location);
                        memory[location] = accumulator;
                        Thread.Sleep(2000);
                    }
                    break;
                default:
                    break;
            }
        }

        // Before running an SML program, we must load, or place, the code into memory.
        private void LoadWordsToMemory()
        {
            // The first instruction (or statement) of every SML program is always placed in location 00.
            for (int i = 0; i < SIZE; i++)
            {
                int code = 0;

                if (i < 10)
                {
                    Console.Write("Enter code to location {0}: ", ("0" + i));
                    code = Convert.ToInt32(Console.ReadLine());

                    if (CheckCode(code))
                    {
                        if (code.ToString().Substring(0, 2).Equals("43"))
                        {
                            memory[i] = code;
                            break;
                        }
                        memory[i] = code;
                    }
                    else
                        --i;
                }
                else
                {
                    Console.Write("Enter code to location {0}: ", i);
                    code = Convert.ToInt32(Console.ReadLine());

                    if (CheckCode(code))
                    {
                        if (code.ToString().Substring(0, 2).Equals("43"))
                        {
                            memory[i] = code;
                            break;
                        }
                        memory[i] = code;
                    }
                    else
                        --i;
                }
            }

            Console.Clear();
        }

        // Display operation code and meaning
        private void DisplayOperationCode()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < ioOperations.GetLength(0); i++)
            {
                for (int j = 0; j < ioOperations.GetLength(1); j++)
                {
                    if (j == 0)
                        Console.Write("{0, -13}", ioOperations[i,j]);
                    else if (j == 1)
                        Console.Write("{0,-5}", ioOperations[i, j]);
                    else
                        Console.Write("{0}", ioOperations[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter commands into the accumulator:");
        }

        private Boolean CheckCode(int code)
        {
            // Verifies that the code is length of four
            if (code.ToString().Length == 4)
            {
                // Verifies that code contains valid operation code
                int operationCode = int.Parse(code.ToString().Substring(0, 2));

                for (int i = 0; i < operationCodeList.Length; i++)
                    if (operationCodeList[i] == operationCode)
                        return true;

                Console.WriteLine("Operation code not found!");
                return false;
            }
            else
            {
                Console.WriteLine("Incorrect format! Must be an integer of length 4!");
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Simpletron sml = new Simpletron();
        }
    }
}