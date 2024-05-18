// Задание 2.

using System.Runtime.CompilerServices;

Dictionary<string, string> firms = new()
{
    { "Sony", "Japan" },
    { "Sumsung", "Korea" },
    { "Apple", "USA" }
};

Console.WriteLine("Список фирм: ");
foreach (var firm in firms)
    Console.WriteLine($"{firm.Key} - {firm.Value}");

Console.WriteLine();

Console.WriteLine("Сколько фирм вам надо добавить в словарь?");
int userN = Int32.Parse(Console.ReadLine());
string userFirmKey;
string userFirmValue;

for (int i = 0; i < userN; i++)
{
    Console.WriteLine("Введите название фирмы: ");
    userFirmKey = Console.ReadLine();

    Console.WriteLine("Введите страну фирмы");
    userFirmValue = Console.ReadLine();

    firms.Add(userFirmKey, userFirmValue);
}

Console.WriteLine();

Console.WriteLine("Список фирм: ");
foreach (var firm in firms)
    Console.WriteLine($"{firm.Key} - {firm.Value}");

// Задание 3.

Console.WriteLine();

Console.WriteLine("Введите название фирмы");
userFirmKey = Console.ReadLine();

if (firms.ContainsKey(userFirmKey))
    Console.WriteLine($"{userFirmKey} - {firms[userFirmKey]}");
else
    Console.WriteLine($"Страны с фиром {userFirmKey} не найдено!");

Console.WriteLine();

Console.WriteLine("Введите страну");
userFirmValue = Console.ReadLine();
int count = 0;

foreach (var firm in firms)
    if (firm.Value == userFirmValue)
    {
        count++;
    }
Console.WriteLine($"Найдено {count} совпадений");

Console.WriteLine();

Console.WriteLine("Введите название фирмы, которую хотите удалить из списка");
userFirmKey= Console.ReadLine();
firms.Remove(userFirmKey);

Console.WriteLine();

Console.WriteLine("Список фирм после удаления введенной фирмы: ");
foreach (var firm in firms)
    Console.WriteLine($"{firm.Key} - {firm.Value}");