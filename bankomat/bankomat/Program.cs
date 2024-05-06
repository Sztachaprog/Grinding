
public class Program
{
    public static int SetPin()
    {
        
        Console.Write("Firstly set your pin: ");
        string input = Console.ReadLine();
        int pinUser;
        if (int.TryParse(input, out pinUser))
        {
            if (input.Length < 4)
            {
                Console.WriteLine("Pin is to short");
                return 0;
            }
            else
            {
                return pinUser;
            }
        }

        else
        {
            Console.WriteLine("Invalid input. Please enter only digits.");
            return 0;
        }
    }
    public static int LoginMethod()
    {
        Console.Write("Enter your login pin: ");
        string input = Console.ReadLine();
        int loginPinUser;
        
        if (int.TryParse(input, out loginPinUser))
        {
            if(input.Length < 4) 
            {
                Console.WriteLine("Pin is to short");
                return 0;
            }
            else
            {
                return loginPinUser;
            }
        }
        else
        {
            Console.Write("Invalid input. Please enter only digits.");
            return 0;
        }
            
    }
    public static int ChangePin(int pinUser)
    {
        Console.Write("Please input your old pin: ");
        string oldPinInput = Console.ReadLine();
        int oldPin;
        if ((int.TryParse(oldPinInput, out oldPin)) && oldPin == pinUser)
        {
            Console.Write("correct, now input yout new pin: ");
            string newPinInput = Console.ReadLine();
            int newPin;
            if(int.TryParse(newPinInput, out newPin))
            {
                if(newPinInput.Length < 4)
                {
                    Console.WriteLine("too short");
                    return -1;
                }
                else
                {
                    Console.WriteLine("you've changed your pin");
                    return newPin;
                }
            }   
        }
        else
        {
            Console.WriteLine("invalid pin, try digits");
            return -1;
        }
        return 0;
    }

public static void Main()
    {
        Console.WriteLine("Hello, welcome to our bankomates.");
        Console.Write("1.SetPin"); Console.Write("         "); Console.WriteLine("2.Login");
        Console.Write("What do you want to do?: ");
        
        string mainHomeInput = Console.ReadLine();
        string mainHomeInputToUpper = mainHomeInput.ToLower();
        int pinUser = 0;
        do {
            if (mainHomeInputToUpper == "setpin" || mainHomeInputToUpper == "1")
            {
                pinUser = SetPin();
            }
            else if (mainHomeInputToUpper == "login" || mainHomeInputToUpper == "2")
            {
                pinUser = LoginMethod();
            }
        }while(pinUser < 4 );
        Console.Write("Welcome to your account\n1.Withdraw money   2.Deposit money   3.Change pin\nWhats Next?: ");
        string inputAfterLogin = Console.ReadLine();
        string inputAfterLoginToLower = inputAfterLogin.ToLower();
        while (true)
        {
            if (inputAfterLoginToLower == "1" || inputAfterLoginToLower == "withdraw money")
            {
                Console.WriteLine("How much money do you want to withdraw?");
                string howMuchMoneyWithdraw = Console.ReadLine();
                int howMuchMoneyWithdrawToMoney;
                if (int.TryParse(howMuchMoneyWithdraw, out howMuchMoneyWithdrawToMoney))
                {
                    Console.WriteLine("okey, we are processing");
                    for (int i = 20; i >= 0; i--)
                    {
                        Console.WriteLine($"Time left: {i} seconds");
                        Thread.Sleep(1000); // Czekaj 1 sekundę (1000 milisekund)
                    }
                    Console.WriteLine("Here you go, seeya");
                    

                }
                else
                {
                    Console.WriteLine("invalid input");
                }


            }
            else if (inputAfterLoginToLower == "2" || inputAfterLoginToLower == "Deposit money")
            {
                Console.WriteLine("How much money do you want to deposit?");
                string howMuchMoneyWithdraw = Console.ReadLine();
                int howMuchMoneyWithdrawToMoney;
                if (int.TryParse(howMuchMoneyWithdraw, out howMuchMoneyWithdrawToMoney))
                {
                    Console.WriteLine("Please deposit money to the bankomates and wait");
                    for (int i = 20; i >= 0; i--)
                    {
                        Console.WriteLine($"Time left: {i} seconds");
                        Thread.Sleep(1000); // Czekaj 1 sekundę (1000 milisekund)
                    }
                    Console.WriteLine("Your money is deposited");

                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            else if (inputAfterLoginToLower == "3" || inputAfterLoginToLower == "change pin")
            {
                ChangePin(pinUser);

            }
            else
            {
                Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                // Zapytaj użytkownika ponownie
                Console.Write("Whats Next?: ");
                inputAfterLogin = Console.ReadLine();
                inputAfterLoginToLower = inputAfterLogin.ToLower();
                continue; // Kontynuuj pętlę, aby sprawdzić nowy wybór użytkownika
            }
            break;

        }
        
    }
}
