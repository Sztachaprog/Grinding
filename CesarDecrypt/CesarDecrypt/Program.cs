using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // Asking user to type a secret message to convert into crypted message
            // Asking the user to input a secret message to convert it into an encrypted one

            Console.WriteLine("Type a secret message and we will convert it for you into an encrypted message: ");
            string userMessage = Console.ReadLine();

            // Converting captured string from user to array of chaaracters

            char[] secretMessage = userMessage.ToCharArray();

            // New empty array of characters with length of "secretMessage"

            char[] encryptedMessage =  new char[secretMessage.Length];


        }
    }
}