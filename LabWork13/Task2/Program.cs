using System.Text;
while (true)
{
    Console.WriteLine("Введите строку");
    string userString = Console.ReadLine();
    userString = userString.Trim();

    while (userString.Contains("  "))
    {
        userString = userString.Replace("  ", " ");
    }

    Console.WriteLine("Выберите регистр: 1.Верхний / 2.Нижний / 3.Инвертированный");
    int userRegister = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Получившаяся строка");
    switch (userRegister)
    {
        case 1:
            Console.WriteLine(userString.ToUpper());
            break;
        case 2:
            Console.WriteLine(userString.ToLower());
            break;
        case 3:
            StringBuilder stringBuilder = new StringBuilder(userString);
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] == char.ToLower(stringBuilder[i]))
                    stringBuilder[i] = char.ToUpper(stringBuilder[i]);
                else
                    stringBuilder[i] = char.ToLower(stringBuilder[i]);
            }
            Console.WriteLine(stringBuilder);
            break;
        default:
            Console.WriteLine("Неверно введен регистр");
            break;
    }
    Console.WriteLine();
}