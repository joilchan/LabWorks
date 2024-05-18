namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            Console.WriteLine("Подтвердите пароль");
            string confirmPassword = Console.ReadLine();

            if (user.IsCorrectUserData(login, password, confirmPassword))
                Console.WriteLine("Вы успешно зарегистрировались");
            else
                Console.WriteLine("Не удалось зарегистрироваться. Пароль и подтверждение пароля не совпадают.");

            Console.WriteLine();

            Console.WriteLine("Введите месяц");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(user.GetDaysCount(month, year));
        }
    }
}
