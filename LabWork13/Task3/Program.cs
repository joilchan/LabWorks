Console.WriteLine("Введите строку");
string userString = Console.ReadLine();
userString = userString.Trim();
userString.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(userString);

for (int i = 0; i < userString.Length; i++)
{

}