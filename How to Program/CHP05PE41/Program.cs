using System;

/**
 * 5.41 (Enforcing Privacy with Cryptography) 
 * The explosive growth of Internet communications and data storage on Internet-connected computers has greatly increased 
 * privacy concerns. The field of cryptography is concerned with coding data to make it difficult (and hopefully—with the most 
 * advanced schemes—impossible) for unauthorized users to read. In this exercise you’ll investigate a simple scheme for 
 * encrypting and decrypting data. A company that wants to send data over the Internet has asked you to write a program that 
 * will encrypt it so that it may be transmitted more securely. All the data is transmitted as four-digit integers. Your app 
 * should read a four-digit integer entered by the user and encrypt it as follows: 
 * Replace each digit with the result of adding 7 to the digit and getting the remainder after dividing the new value 
 * by 10. Then swap the first digit with the third, and swap the second digit with the fourth. Then display the encrypted 
 * integer. Write a separate app that inputs an encrypted four-digit integer and decrypts it (by reversing the encryption 
 * scheme) to form the original number. Use the format specifier D4 to display the encrypted value in case the number 
 * starts with a 0.
 */ 
namespace CHP05PE41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four digit integer: ");
            int password = Convert.ToInt32(Console.ReadLine());

            int digit4 = ((password % 10) + 7) % 10;
            password = (password / 10);
            int digit3 = ((password % 10) + 7) % 10;
            password = (password / 10);
            int digit2 = ((password % 10) + 7) % 10;
            password = (password / 10);
            int digit1 = ((password % 10) + 7) % 10;

            String encryptedPassword = "" + digit3 + digit4 + digit1 + digit2;

            Console.WriteLine(encryptedPassword);

            digit4 = (digit4 + 3) % 10;
            digit3 = (digit3 + 3) % 10;
            digit2 = (digit2 + 3) % 10;
            digit1 = (digit1 + 3) % 10;

            encryptedPassword = "" + digit1 + digit2 + digit3 + digit4;
            Console.WriteLine(encryptedPassword);
        }
    }
}
