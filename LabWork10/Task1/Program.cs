using Task1;

// 1 задание

Client[] clients =
    [
        new Client ("Иван", "Пумпинова 3", 323),
        new Client ("Гриша", "Ленинградский 45", 234),
        new Client ("Саша", "Пумпинова 3", 123),
        new Client ("Сергей", "Папанина 24", 567),
        new Client ("Антон", "Гагарина 445", 394),
    ];

Console.WriteLine("Исходный массив клиентов");
foreach (var client in clients)
    Console.WriteLine(client);

Console.WriteLine();

Array.Sort(clients);
Console.WriteLine("Массив клиентов после сортировки");
foreach (var client in clients)
    Console.WriteLine(client);

// 2 задание

Console.WriteLine();

Array.Sort<Client>(clients);
Console.WriteLine("Массив клиентов после сортировки(с обобщениями)");
foreach (var client in clients)
    Console.WriteLine(client);

// 3 задание

Console.WriteLine();

Client nikita = new Client("Никита", "Павлаусова 32", 67);
Client gena = new Client("Гена", "Московский 33", 67);

Console.WriteLine(nikita);
Console.WriteLine(gena);

Console.WriteLine($"Клиент Никита равен клиенту Гена? {nikita.Equals(gena)}");
Console.WriteLine($"Клиент Никита равен клиенту Никита? {nikita.Equals(nikita)}");

// 4 задание

Console.WriteLine();

Client dima = (Client)nikita.Clone();

dima.Name = "Дима";
Console.WriteLine(dima);
Console.WriteLine(nikita);

// 5 задания 