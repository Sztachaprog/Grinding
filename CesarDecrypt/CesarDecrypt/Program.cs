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
            string userMessageToLower = Console.ReadLine();
            string userMessage = userMessageToLower.ToLower();

            // Converting captured string from user to array of chaaracters

            char[] secretMessage = userMessage.ToCharArray();

            // New empty array of characters with length of "secretMessage"

            char[] encryptedMessage = new char[secretMessage.Length];

            // Creating loop For that loops through each character of "secretMessage"

            for (int i = 0; i < secretMessage.Length; i++)
            {
                // Creating char that store position of char 'i' from "secretMessage"
                // for example in "Hello world" secretMessage[0] is H
                char letter = secretMessage[i];

                // Searching for the index position of "letter" within the "alphabet" array and store it
                int charPosition = Array.IndexOf(alphabet, letter);

                // Adding 3 positions to a letter
                int cryptedLetter = (charPosition + 3) % 26;

                // Creating new encrypted letter
                char newEncryptedMessage = alphabet[cryptedLetter];

                // Assigning the new encrypted letter to the message:
                encryptedMessage[i] = newEncryptedMessage;
                
            }

            String.Join("", encryptedMessage);
            Console.WriteLine(encryptedMessage);

        }
    }
}