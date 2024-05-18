using Task2;

Square square = new Square(6);
Console.WriteLine(square.Name);
square.PrintInfo();
Console.WriteLine($"Площадь квадрат: {square.GetArea()}");
Console.WriteLine($"Периметр квадрат: {square.GetPerimeter()}");
