using System;

namespace SavingInterface
{
    class Program
    {
        // Instances
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party"); tdl.Add("4"); tdl.Add("5");

            PasswordManager pm = new PasswordManager("iluvpie", true, "Password\n------");

            // Calling the instance with a method Display
            tdl.Display();
            tdl.Reset();
            tdl.Display();

            pm.Display();
            pm.Reset();
            pm.Display();

            pm.ChangePassword("dupa", "dupa");


        }
    }
}
