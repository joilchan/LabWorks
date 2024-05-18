using System.Text.RegularExpressions;

Console.WriteLine("Введите номер телефона ( +7(9xx)xxx-xx-xx )");
string input = Console.ReadLine();
string pattern = @"^(\+7|8)\(9\d{2}\)\d{3}-\d{2}-\d{2}$";
Regex regex = new Regex(pattern);
if (regex.IsMatch(input))
    Console.WriteLine("Номер введен корректно");
else
    Console.WriteLine("Номер введен не корректно");
