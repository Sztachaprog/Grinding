using System;
using System.Text.RegularExpressions;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> 362d4ef47d1a29c271c017b80dafc18d961936bd

namespace CaesarCipher
{
    class Program
    {
<<<<<<< HEAD

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
=======
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public static void Encrypt(string userMessage)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] secretMessage = userMessage.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < userMessage.Length; i++)
            {
                // Creating char that store position of char 'i' from "secretMessage"
                // for example in "Hello world" secretMessage[0] is H
                char letter = userMessage[i];

                // Searching for the index position of "letter" within the "alphabet" array
                int charPosition = Array.IndexOf(alphabet, letter);

                // Adding 3 positions to a letter
                int cryptedLetter = (charPosition + 3) % 26;

                // Creating new encrypted letter
                char newEncryptedMessage = userMessage[cryptedLetter];

                // Assigning the new encrypted letter to the message:
                encryptedMessage[i] = newEncryptedMessage;

            }

            string newwEncryptedMessage = String.Join("", userMessage);
            Console.WriteLine(newwEncryptedMessage);
        }

        static void Main(string[] args)
        {

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


            // Asking user to type a secret message to convert into crypted message
            // Asking the user to input a secret message to convert it into an encrypted one
            Console.WriteLine("Type a secret message and we will convert it for you into an encrypted message: ");
            string userMessage = Console.ReadLine().ToLower();

            while (true) 
>>>>>>> 362d4ef47d1a29c271c017b80dafc18d961936bd
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
<<<<<<< HEAD
            }
=======
<<<<<<< HEAD
            }
=======
            } 
>>>>>>> 362d4ef47d1a29c271c017b80dafc18d961936bd
>>>>>>> a98a84e237ca865163572eb0885b123f191f5499
            // Converting captured string from user to array of chaaracters

            //char[] secretMessage = userMessage.ToCharArray();

            // New empty array of characters with length of "secretMessage"

<<<<<<< HEAD
            //char[] encryptedMessage =  new char[secretMessage.Length];

            // Creating loop For that loops through each character of "secretMessage"

            /* for(int i = 0; i < secretMessage.Length; i++)
             {
                 // Creating char that store position of char 'i' from "secretMessage"
                 // for example in "Hello world" secretMessage[0] is H
                 char letter = secretMessage[i];
=======
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                // Creating char that store position of char 'i' from "secretMessage"
                // for example in "Hello world" secretMessage[0] is H
                char letter = secretMessage[i];
>>>>>>> a98a84e237ca865163572eb0885b123f191f5499

                 // Searching for the index position of "letter" within the "alphabet" array
                 int charPosition = Array.IndexOf(alphabet, letter);

                 // Adding 3 positions to a letter
                 int cryptedLetter = (charPosition + 3) % 26;

                 // Creating new encrypted letter
                 char newEncryptedMessage = alphabet[cryptedLetter];

<<<<<<< HEAD
                 // Assigning the new encrypted letter to the message:
                 encryptedMessage[i] = newEncryptedMessage;
=======
                // Assigning the new encrypted letter to the message:
                encryptedMessage[i] = newEncryptedMessage;

            }
>>>>>>> a98a84e237ca865163572eb0885b123f191f5499

             }

             string newwEncryptedMessage = String.Join("", encryptedMessage);
             Console.WriteLine(newwEncryptedMessage);*/
            Encrypt(userMessage);

<<<<<<< HEAD
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
=======
>>>>>>> 362d4ef47d1a29c271c017b80dafc18d961936bd


        }
    }
}