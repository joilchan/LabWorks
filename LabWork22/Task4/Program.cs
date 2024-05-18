using System.Diagnostics.CodeAnalysis;

namespace Task4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var fileName = "22(1).txt";
            var fileName2 = "22(2).txt";
            var fileName3 = "22(3).txt";
            Task task1 = ReadFileAsync(fileName);
            Task task2 = ReadFileAsync(fileName2);
            Task task3 = ReadFileAsync(fileName3);
            await Task.WhenAll(task1, task2, task3);
        }

        static async Task ReadFileAsync(string fileName)
        {
            using (StreamReader reader = new(fileName, true))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine($"{fileName} : {line}");
                }
            }
        }
    }
}
