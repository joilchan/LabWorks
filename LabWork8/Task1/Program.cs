using Task1;

Client ivan = new("Иван", "Павлоусова 45", 345);
Client dima = new("Дима", "Гагарина 24", 535);

Console.WriteLine(ivan); // не явно
Console.WriteLine(dima.ToString()); //явно

Console.WriteLine();

Console.WriteLine($"Клиент Иван равен клиенту Дима? {ivan.Equals(dima)}"); //false, т.к. (ivan != dima)
Console.WriteLine($"Клиент Иван равен клиенту Иван? {ivan.Equals(ivan)}"); //true, т.к. (ivan = ivan)

Console.WriteLine();

Square square = new (2, 2);

square.PrintInfo();
Console.WriteLine("Периметр фигуры: " + square.GetPerimeter());
Console.WriteLine("Площадь фигуры: " + square.GetArea());



