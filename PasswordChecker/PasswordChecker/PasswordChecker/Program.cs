using PasswordChecker;

int minLenght = 8;
string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lowercase = "abcdefghijklmnopqrstuvwxyz";
string digits = "0123456789";
string specialChars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

Console.WriteLine("Enter the password: ");
string password = Console.ReadLine();
int score = 0;
if(password.Length >= minLenght)
{
    score++;
}
if (Tools.Contains(password, uppercase)) // (password.Intersect(uppercase).Any())
{
    score++;
}
if (Tools.Contains(password, lowercase)) // (password.Intersect(lowercase).Any())
{
    score++;
}
if (Tools.Contains(password, digits)) // (password.Intersect(digits).Any())
{
    score++;
}
if (Tools.Contains(password, specialChars)) // (password.Intersect(specialChars).Any())
{
    score++;
}
switch(score)
{
    case 1:
        Console.WriteLine("the password is weak");
        break;  
    case 2:
        Console.WriteLine("the password is medium");
        break;
    case 3:
        Console.WriteLine("the password is strong");
        break;
    case 4:
        Console.WriteLine("the password is extremely strong");
            break;
    case 5:
        Console.WriteLine("the password is extremely strong");
        break ;

}
