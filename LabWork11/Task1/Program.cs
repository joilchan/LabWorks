// Задание 1.

List<string> vegetables = new ();
vegetables.AddRange(new string[] { "Огурец", "Капуста", "Свекла"});

Console.WriteLine("Список овощей: ");

for (int i = 0; i < vegetables.Count; i++)
{
    Console.WriteLine($"{i + 1}. {vegetables[i]}");
}

Console.WriteLine("Сколько овощей вам надо добавить в список?");
int userN = Int32.Parse(Console.ReadLine());

for (int i = 0;i < userN; i++)
{
    Console.WriteLine("Какой овощь вы хотите добавить в список?");
    string userString = Console.ReadLine();
    vegetables.Add(userString);
}

Console.WriteLine("Список овощей: ");

for (int i = 0; i < vegetables.Count; i++)
{
    Console.WriteLine($"{i + 1}. {vegetables[i]}");
}

