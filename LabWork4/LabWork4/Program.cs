Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        numbers[i, j] = -1;
    }

}

//Random random = new Random();
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; i < columns; j++)
//    {
//        int randomRow = random.Next(rows);
//        int randomColumns = random.Next(columns);
//        numbers[randomRow, randomColumns] = -2;
//    }
//}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {


        Console.Write(numbers[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();