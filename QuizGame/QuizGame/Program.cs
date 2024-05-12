using Accord.Math;
using System;
using System.IO;

namespace TrueOrFalse
{
    class Program
    {
       

        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            //Creating array with questions
            string[] questions = { "The biggest mammal is blue whale?", "capital of Poland is Coratia?", "Was the Polish baptism in 996??", "Leonardo de Caprio painted the Mona Lisa?"};

            //Creating bool array with length of questions array
            bool[] answers = new bool[]
            {
                true,
                false,
                false,
                false,
            };

            //Creating bool array with reposness from user
            bool[] responses = new bool[questions.Length];

            //Creating if loop that checks if questions and answers are with the same length

            if(answers.Length != questions.Length)
            {
                Console.WriteLine("You didnt answer for all questions");
            }

            int askingIndex = 0;

            // Foreach loop that checks every question variable
            foreach(string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True of False?");

                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);

                while(!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false' ");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex++] = inputBool;
                
            }
           foreach(bool response in responses)
            {
                Console.WriteLine(response);
            }

            //to loop through the responses
            int scoringIndex = 0;
            //to count the number of correct responses
            int score = 0;

            foreach(bool answer in answers)
            {
                bool responsIndexing = responses[scoringIndex++];
                Console.WriteLine($"Input: {responsIndexing} || Answer: {answer}");
                if(responsIndexing ==  answer)
                {
                    score++;
                }
                ;

            }
            Console.WriteLine($"You've got {score} of 4 correct");



        }
    }
}
