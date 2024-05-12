using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace CaesarCipher
{
    class Program
    {

        public static bool IsAllLetters(string s)
        {
            bool containsLetter = false;
            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    containsLetter = true;
                }
                else if (c != ' ')
                {
                    return false; // Znaleziono znak, który nie jest literą ani spacją
                }
            }

            return containsLetter; // Jeśli przynajmniej jedna litera została znaleziona, zwróć true, w przeciwnym razie false

        }
        public static void Encrypt()
        {
            
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("What message you want to encrypt?: ");
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

            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
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
        public static void Decrypt()
        {

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("What message you want to encrypt?: ");
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

            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                // Creating char that store position of char 'i' from "secretMessage"
                // for example in "Hello world" secretMessage[0] is H
                char letter = secretMessage[i];

                // Searching for the index position of "letter" within the "alphabet" array
                int charPosition = Array.IndexOf(alphabet, letter);

                // Adding 3 positions to a letter
                int cryptedLetter = (charPosition - 3) % 26;

                // Creating new encrypted letter
                char newEncryptedMessage = alphabet[cryptedLetter];

                // Assigning the new encrypted letter to the message:
                encryptedMessage[i] = newEncryptedMessage;

            }

            string newwEncryptedMessage = String.Join("", encryptedMessage);
            Console.WriteLine(newwEncryptedMessage);

        }

        static void Main(string[] args)
        {
            string userInput = "".ToLower();
            Console.WriteLine("You wanna 1.Encrypt or 2.Decrypt a message?: ");
            userInput = Console.ReadLine();

            if (userInput == "1" || userInput == "encrypt")
            {
                Encrypt();
            }
            else if(userInput == "2" || userInput == "decrypt")
            {
                Decrypt(); 
            }

            //Console.WriteLine("Your encrypted message is: "); Encrypt();


        }
    }
}