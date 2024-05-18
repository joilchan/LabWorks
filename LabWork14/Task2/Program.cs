using System.Text.RegularExpressions;

Console.WriteLine("Введите строку");
string input = Console.ReadLine();
string pattern = @"\s{2,}";
string replacement = " ";
Regex regex = new Regex(pattern);
input = regex.Replace(input, replacement);
Console.WriteLine($"Строка после замены: {input}");
