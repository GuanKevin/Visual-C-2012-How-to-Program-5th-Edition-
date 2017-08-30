using System;

/**
 * 8.27 (Sieve of Eratosthenes) 
 * A prime number is any integer greater than 1 that’s evenly divisible only by itself and 1. 
 * The Sieve of Eratosthenes finds prime numbers. It operates as follows:
 * (SEE BOOK)
 */ 
namespace CHP08PE27
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] sieveOfEratosthenesArray = new bool[1000];

            for (int i = 2; i < sieveOfEratosthenesArray.Length; i++)
                sieveOfEratosthenesArray[i] = true;

            for (int i = 2; i < sieveOfEratosthenesArray.Length; i++)
            {
                if (sieveOfEratosthenesArray[i] == true)
                {
                    for (int j = i + 1; j < sieveOfEratosthenesArray.Length; j++)
                        if (j % i == 0)
                            sieveOfEratosthenesArray[j] = false;
                }
            }

            int primeCounter = 0;

            for (int i = 0; i < sieveOfEratosthenesArray.Length; i++)
            {
                if (sieveOfEratosthenesArray[i] == true)
                {
                    ++primeCounter;
                    if (primeCounter % 10 == 0)
                        Console.WriteLine("{0, -4}", i);
                    else
                        Console.Write("{0, -4}", i);
                }
            }
            Console.WriteLine("\nThere are {0} prime numbers between 0 - 999.", primeCounter);
        }
    }
}