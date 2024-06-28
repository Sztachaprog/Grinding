using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {     
        // Propertys
        public string HeaderSymbol { get; private set; }

        private int _passwordLength = 8;
        private string _password;
        private string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= _passwordLength)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("nie");
                }
            } 
        }

        public bool Hidden
        { get; private set; }

        // Constructors
        public PasswordManager(string password, bool hidden, string headerSymbol)
        {
            Password = password;
            Hidden = hidden;
            HeaderSymbol = headerSymbol;
        }

        // Methods

        public void Display()
        {
            Console.WriteLine(HeaderSymbol); 
            if (Hidden == false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine("******");
            }
        }
        public void Reset()
        {
            Password = string.Empty;
            HeaderSymbol = string.Empty;
            Hidden = false;
        }

        public bool ChangePassword(string oldPassword,string newPassword)
        {
            if (oldPassword == Password)
            {
                Password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}