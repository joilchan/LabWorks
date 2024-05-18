using System.Text.RegularExpressions;

Console.WriteLine("Введите пароль");
string input = Console.ReadLine();
string pattern = @"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!?.]).{6,}";
Regex regex = new Regex(pattern);

while (!regex.IsMatch(input))
{
    Console.WriteLine("Пароль не надежен. Введите ещё раз");
    input = Console.ReadLine();
}
Console.WriteLine("Пароль надежен");