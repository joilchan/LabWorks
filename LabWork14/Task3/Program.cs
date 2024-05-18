using System.Text.RegularExpressions;

Console.WriteLine("Введите e-mail адрес ( логин@доменноеИмя ). ");
string input = Console.ReadLine();
string pattern = @"^[a-z-_]+@([a-z\d]+\.)+[a-z]{2,}$";
Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
if (regex.IsMatch(input))
    Console.WriteLine("e-mail введен корректно");
else
    Console.WriteLine("e-mail введен не корректно");