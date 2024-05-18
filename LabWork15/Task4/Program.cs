class Program
{
    delegate int MathOperation(int x);

    static int GetSquare(int x)
    {
        return x * x;
    }

    static int Factorial(int x)
    {
        if (x == 0)
            return 1;
        if (x < 0)
            return -1;
        return x * Factorial(x - 1);
    }

    static int Module(int x)
    {
        if (x < 0)
            return -x;
        return x;
    }

    static void Main()
    {
        Console.WriteLine("Введите число");
        int value = Convert.ToInt32(Console.ReadLine());

        MathOperation[] mathOperations = [GetSquare, Factorial, Module];

        foreach (var mathOperations in mathOperations)
        {

        }
        
    }
}

