using Task1;

Client dima = new Client();
Client ivan = new("Иван", "Папанина 45", 233);
ivan.Print();
dima.Print();

Console.WriteLine();

ivan.Name = "";
ivan.Address = "";
ivan.Sum = -324;
ivan.Print();

Console.WriteLine();

ivan.Name = "Aндрей";
ivan.Address = "Пумпум 3";
ivan.Sum = 324;
ivan.Print();