using System.Linq;

Console.WriteLine("Введите строку");
string userString = Console.ReadLine();
Console.WriteLine($"Количество символов в строке: {userString.Length}");

int userStringWithoutSpace = userString.Replace(" ", "").Length;
Console.WriteLine($"Количество символов в строке без учета пробелов: {userStringWithoutSpace}");

int lettersCount = 0;
foreach (var symbol in userString )
{
    if (Char.IsLetter(symbol))
        lettersCount++;
}
Console.WriteLine($"Количество букв в строке: {lettersCount}");

Console.WriteLine("Введите символ");
char userSymbol = Convert.ToChar(Console.ReadLine());
Console.WriteLine($"Позиции введенного символа:");
if (!userString.Contains(userSymbol))
    Console.WriteLine("Символ не найден");
for ( int i = 0; i < userString.Length; i++ )
{
    if (userString[i] == userSymbol)
    {
        Console.WriteLine(i + 1);
    }
}


