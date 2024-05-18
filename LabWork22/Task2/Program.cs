namespace Task2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var results = await Task.WhenAll
                (
                    Task.Run(() => GetPower(1.2, 2)),
                    Task.Run(() => GetPower(2, 5)),
                    Task.Run(() => GetPower(2, 6))
                );
            foreach (var result in results)
                Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine(await GetExpressionAsync(2, 1, 2, 2, 2, 3, 2, 4));

        }

        static double GetPower(double a, int x)
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
            return result;
        }

        static async Task<double> GetExpressionAsync(double a1, int x1, double a2, int x2, double a3, int x3, double a4, int x4)
        {
            double devisor = await Task.Run(() => GetPower(a1, x1)) + await Task.Run(() => GetPower(a2, x2));
            double devision = await Task.Run(() => GetPower(a3, x3)) - await Task.Run(() => GetPower(a4, x4));
            return devisor / devision;
            //return (GetPower(a1, x1) + GetPower(a2, x2)) / (GetPower(a3, x3) - GetPower(a4, x4));
        }
    }
}
