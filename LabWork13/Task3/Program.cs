Console.WriteLine("Введите строку");
string userString = Console.ReadLine();
userString = userString.Trim();
string[] subStrings = userString.Split('.', '?', '!');

foreach (string subString in subStrings)
{
    if (String.IsNullOrWhiteSpace(subString))
        subString.Remove(0);
    else
        Console.WriteLine(subString.Trim());
}

Console.WriteLine("Введите строку");
string userString1 = Console.ReadLine();
userString = userString.Trim();
string[] subStrings1 = userString.Split('.', '?', '!', ',', ' ');

foreach (string subString in subStrings1)
{
    if (String.IsNullOrWhiteSpace(subString))
        subString.Remove(0);
    else
        Console.WriteLine(subString.Trim());
}
// Привет, меня зовут Гриша! Я люблю кодить. КАК ДЕЛА?! М?