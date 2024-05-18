internal class Program
{
    static async Task Main(string[] args)
    {
        await Task.Run(() => GetPower(1.2, 2));
        await Task.Run(() => GetPower(3, 4));
        await Task.Run(() => GetPower(4, 5));

        Console.WriteLine();

        await Task.WhenAll
            (
                Task.Run(() => GetPower(2, 4)),
                Task.Run(() => GetPower(2, 5)),
                Task.Run(() => GetPower(2, 6))
            );
    }

    static void GetPower(double a, int x)
    {
        double result = 1;
        if (x > 0)
        {
            for (int i = 0; i < x; i++)
                result *= a;
        }
        else if (x < 0)
        {
            x = -x;
            for (int i = 0; i < x; i++)
                result *= a;
            result = 1 / result;
        }

        Console.WriteLine($"{a}^{x} = {result}");
    }
}
