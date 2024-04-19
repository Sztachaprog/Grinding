using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            string noiseChoiceLower;
            do
            {
                Console.Write("Type YES or NO: ");
                string noiseChoice = Console.ReadLine();
                noiseChoiceLower = noiseChoice.ToLower();

                if (noiseChoiceLower == "yes")
                {
                    Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\r\nYou walk towards it. Do you open it or knock?");
                }
                else if (noiseChoiceLower == "no")
                {
                    Console.WriteLine($"Like always vampires win");
                    Environment.Exit(0);
                }

            } while (noiseChoiceLower != "yes" && noiseChoiceLower != "no");

            string doorChoiceLower;
            do
            {
                Console.Write("Do you want to OPEN or KNOCK?: ");
                string doorChoice = Console.ReadLine();
                doorChoiceLower = doorChoice.ToLower();
                if (doorChoiceLower == "knock")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                }
                else if (doorChoiceLower == "open")
                {
                    Console.WriteLine("The doors is closed! you've got three keys, lets check them");
                    Console.Write("Enter a number (1=3): ");
                    string key = Console.ReadLine();
                    switch (key)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!\r\nThe door opens and \n Vampires wins");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.\r\nVampires wins.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the second key. The door doesn't open.\r\nVampires wins.");
                            break;
                        default:
                            Console.WriteLine("Vampires wins");
                            break;

                    }
                    Environment.Exit(0);
                }
            } while (doorChoiceLower != "knock" && doorChoiceLower != "open");
            Console.Write("Type your answer: ");
            string riddleAnswer = Console.ReadLine();
            string riddleAnswerLower = riddleAnswer.ToLower();
            if (riddleAnswerLower == "nothing" && riddleAnswerLower == "nic")
            {
                Console.WriteLine("Vampires win");
            }
            else if (riddleAnswerLower == "attack")
            {
                Console.WriteLine("You decided to attack. Vampires are defeated and humans win, but are they really?...");
            }
            else
            {
                Console.WriteLine("Remember Vampires always wins");
            }

        }
    }
}
