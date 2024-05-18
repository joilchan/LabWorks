internal class Program
{
    internal class User
    {
        private int login;
        private int password;

        public bool IsCorrectUserData(string login, string password, string confirmPassword)
        {
            bool isLoginCorrect = login.Length > 0;
            bool isPaswordCorrect = password.Length > 0;
            bool isConfirmCorrect = password == confirmPassword;
            if (isLoginCorrect && isPaswordCorrect && isConfirmCorrect)
                return true;
            return false;
        }
    }

    private static void Main(string[] args)
    {
        User user = new User();

        Console.WriteLine("Введите логин");
        string login = Console.ReadLine();

        Console.WriteLine("Введите пароль");
        string password = Console.ReadLine();

        Console.WriteLine("Подтвердите пароль");
        string confirmPassword = Console.ReadLine();

        Console.WriteLine(user.IsCorrectUserData(login, password, confirmPassword));

        if (user.IsCorrectUserData(login, password, confirmPassword))
            Console.WriteLine("Вы успешно зарегистрировались");
        else
            Console.WriteLine("Не удалось зарегистрироваться. Пароль и подтверждение пароля не совпадают.");
    }
}