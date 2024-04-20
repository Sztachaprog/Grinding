using Accord.Math;


int minLenght = 8;
string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lowercase = "abcdefghijklmnopqrstuvwxyz";
string digits = "0123456789";
string specialChars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

Console.WriteLine("Enter the password: ");
string password = Console.ReadLine();
int score = 0;
if (password.Length >= minLenght)
{
    score++;
}
if (password.Intersect(uppercase).Any()) 
{
    score++;
}
if (password.Intersect(lowercase).Any()) 
{
    score++;
}
if (password.Intersect(digits).Any()) 
{
    score++;
}
if (password.Intersect(specialChars).Any()) 
{
    score++;
}
switch (score)
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
        break;

}