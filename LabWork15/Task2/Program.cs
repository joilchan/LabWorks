class Program
{
    delegate void MathOperation (double x, double y);

    static void Sum(double x, double y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }

    static void Difference(double x, double y)
    {
        Console.WriteLine($"{x} - {y} = {x - y}");
    }

    static void Multiplication(double x, double y)
    {
        Console.WriteLine($"{x} * {y} = {x * y}");
    }

    static void Divide(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Нельзя делить на 0");
            return;
        }
        Console.WriteLine($"{x} / {y} = {x / y}");
    }

    static void Main()
    {
        Console.WriteLine("Введите число x");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите число y");
        double y = Convert.ToDouble(Console.ReadLine());

        MathOperation operation = Sum;
        operation += Difference;
        operation += Multiplication;
        operation += Divide;
        operation(x, y);
    }

}