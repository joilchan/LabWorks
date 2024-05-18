Console.WriteLine("Введите строку");
string userString = Console.ReadLine();
userString = userString.Trim();

Console.WriteLine("Выберите регистр: врехний / нижний / инвертированный");
string userRegister = Console.ReadLine();

if (userRegister == "нижний")
{
     Console.WriteLine(userString.ToLower());
}    