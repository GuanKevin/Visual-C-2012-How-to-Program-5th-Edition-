using System;

/**
 * 7.34 (Binary, Octal and Hexadecimal) 
 * Write an app that displays a table of the binary, octal, and hexadecimal equivalents of the decimal numbers in the 
 * range 1–256. If you’re not familiar with these number systems, read Appendix D first.
 */ 
namespace CHP07PE34
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Decimal\tBinary\tOctal\tHexadecimal");
            for (int i = 1; i < 20; i++)
            {
                Console.Write(i);
                Console.Write("\t" + DecimalToBinary(i));
                Console.Write("\t" + DecimalToOctal(i));
                Console.Write("\t" + DecimalToHexadecimal(i));
                Console.WriteLine();
            }
        }

        public static String DecimalToHexadecimal(int number)
        {
            String hexadecimal = "";

            while (number != 0)
            {
                if (number % 16 < 10)
                    hexadecimal = (number % 16) + hexadecimal;
                else
                {
                    switch (number % 16)
                    {
                        case 10:
                            hexadecimal = "A" + hexadecimal;
                            break;
                        case 11:
                            hexadecimal = "B" + hexadecimal;
                            break;
                        case 12:
                            hexadecimal = "C" + hexadecimal;
                            break;
                        case 13:
                            hexadecimal = "D" + hexadecimal;
                            break;
                        case 14:
                            hexadecimal = "E" + hexadecimal;
                            break;
                        default:
                            hexadecimal = "F" + hexadecimal;
                            break;
                    }
                }
                number /= 16;
            }
            return hexadecimal;
        }

        public static int DecimalToOctal(int number)
        {
            String octal = "";

            while (number != 0)
            {
                octal = (number % 8) + octal;
                number /= 8;
            }

            return int.Parse(octal);
        }

        public static int DecimalToBinary(int number)
        {
            String binary = "";

            for (int i = 8; i >= 0; i--)
            {
                if (number >= Math.Pow(2, i))
                {
                    binary += 1;
                    number -= (int)Math.Pow(2, i);
                }
                else
                    binary += 0;
            }

            return int.Parse(binary);
        }
    }
}
