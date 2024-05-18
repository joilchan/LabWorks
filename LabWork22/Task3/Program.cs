namespace Task3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var filename = "22.txt";
            await WriteFileAsync(filename, 2000);
        }

        static async Task WriteFileAsync(string fileName, int rowsAmount)
        {
            Random random = new();
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                for (int i = 0; i < rowsAmount; i++)
                {
                    await writer.WriteLineAsync($"Число №{i + 1}: {random.Next()}");
                }
            }
        }
    }
}
