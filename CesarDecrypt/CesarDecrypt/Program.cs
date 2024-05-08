using System;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    class Program
    {
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


            // Asking user to type a secret message to convert into crypted message
            // Asking the user to input a secret message to convert it into an encrypted one
            Console.WriteLine("Type a secret message and we will convert it for you into an encrypted message: ");
            string userMessage = Console.ReadLine().ToLower();

            while (true) 
            {
                if (IsAllLetters(userMessage))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Try letters");
                    userMessage = Console.ReadLine().ToLower();
                }
            } 
            // Converting captured string from user to array of chaaracters

            char[] secretMessage = userMessage.ToCharArray();

            // New empty array of characters with length of "secretMessage"

            char[] encryptedMessage =  new char[secretMessage.Length];

            // Creating loop For that loops through each character of "secretMessage"

            for(int i = 0; i < secretMessage.Length; i++)
            {
                // Creating char that store position of char 'i' from "secretMessage"
                // for example in "Hello world" secretMessage[0] is H
                char letter = secretMessage[i];

                // Searching for the index position of "letter" within the "alphabet" array
                int charPosition = Array.IndexOf(alphabet, letter);

                // Adding 3 positions to a letter
                int cryptedLetter = (charPosition + 3) % 26;

                // Creating new encrypted letter
                char newEncryptedMessage = alphabet[cryptedLetter];

                // Assigning the new encrypted letter to the message:
                encryptedMessage[i] = newEncryptedMessage;
                
            }

            string newwEncryptedMessage = String.Join("", encryptedMessage);
            Console.WriteLine(newwEncryptedMessage);



        }
    }
}