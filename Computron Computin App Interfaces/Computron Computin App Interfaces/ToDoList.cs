using System;
using System.ComponentModel;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {

        // Propertys
        public string HeaderSymbol { get; private set; }

        public string[] Todos
        { get; private set; }

        // Fields
        private int nextOpenIndex;


        // Constructors
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            HeaderSymbol = "Todos\n------";

        }

        // Methods
        public void Add(string todo)
        {
            if (nextOpenIndex >= Todos.Length)
            {
                Console.WriteLine("Only 5 Quests available");
                return; 
            }

            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            Console.WriteLine(HeaderSymbol);
            foreach (var todo in Todos)
            {
                if (!string.IsNullOrEmpty(todo))
                {  Console.WriteLine(todo); }
            }

        }

        public void Reset()
        {
            HeaderSymbol = string.Empty;
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}