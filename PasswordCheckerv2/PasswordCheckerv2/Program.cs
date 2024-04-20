using System;
using System.Linq;

public class Program
{

    static int MINIMUM_LENGTH = 8;

    public static string getAsciiLowerCaseAlphabet()
    {
        string lowerCaseString = "";
        for (char character = 'a'; character <= 'z'; character++)
            lowerCaseString += character;
        return lowerCaseString;
    }
    /* or (POCZĄTEK (tu się definiuje zmienną, która będzie wzrastać/maleć w trakcie naszej pętli (zaczynamy w tym przypadku od character=„a”;
    WARUNEK (pętla będzie wykonywana tak długo, dopóki warunek jest prawdziwy, w tym przypadku będziemy iterować aż do momentu kiedy napotkamy znak „z”;
    KROK iteracji-zwiększamy po prostu znak o 1, czyli „a”, „b”, „c”, …, aż do „z”)*/
    public static string getAsciiSpecialCharacters()
    { // ogarnij co to jest tablica ASCII -> ważne! https://en.wikipedia.org/wiki/ASCII lub https://www.ascii-code.com/
        string specialCharacters = "";
        for (int i = 33; i <= 126; i++)
        {
            if ((i >= 33 && i <= 47) || (i >= 58 && i <= 64) || (i >= 91 && i <= 96) || (i >= 123 && i <= 126))
                specialCharacters += (char)i;
        }
        return specialCharacters;
    }

    public static string getAsciiDigits()
    {
        string digitsOnly = "";
        for (char digit = '0'; digit <= '9'; digit++)
            digitsOnly += digit;
        return digitsOnly;
    }

    public static int checkUserPasswordStrength(string userPassword)
    {

        int score = 0;

        // Sprawdzamy czy hasło zawiera co najmniej jeden znak z wielkiej litery
        // Użyłem tutaj LINQ (musisz zaimportować System.Linq;) aby to działało: https://stackoverflow.com/questions/20032450/detect-if-a-string-contains-uppercase-characters
        if (userPassword.Length >= MINIMUM_LENGTH)
            score++;

        if (userPassword.Any(char.IsUpper))
            score++;

        // Sprawdzamy czy hasło zawiera co najmniej jeden znak z małej litery
        if (userPassword.Any(char.IsLower))
            score++;

        // Sprawdzamy czy hasło zawiera co najmniej jeden liczbę
        if (userPassword.Any(char.IsDigit))
            score++;

        // Sprawdzamy czy hasło zawiera co najmniej jeden specjalny znak
        if (userPassword.Any(ch => !char.IsLetterOrDigit(ch)))
            score++;
        return score;
    }

    public static void informUserAboutPasswordStrength(int userStrengthPasswordScore)
    {
        switch (userStrengthPasswordScore)
        {
            case 0:
            case 1:
                Console.WriteLine("Your password is very weak! Please provide more special characters, digits, upper cases or lower cases!");
                break;
            case 2:
            case 3:
                Console.WriteLine("You passowrd is medium! Consider more special characters, digits, upper cases or lower cases!");
                break;
            default:
                Console.WriteLine("Your password is very strong! Nice job!");
                break;
        }
    }

    public static void Main()
    {
        string userPasswordFromInput = "";
        do
        {
            Console.WriteLine("Provide a password, to check whether is strong or weak: ");
            userPasswordFromInput = Console.ReadLine();
        } while (userPasswordFromInput.Length <= 0);
        Console.WriteLine($"Your password: {userPasswordFromInput}");

        int passwordStrength = checkUserPasswordStrength(userPasswordFromInput);
        informUserAboutPasswordStrength(passwordStrength);

        // Zakończenie programu ze statusem 0 - czyli pomyślnie się zakończył program
        Environment.Exit(0);
    }///gggg
}