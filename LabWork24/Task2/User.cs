using System.ComponentModel;

namespace Task2
{
    internal class User
    {
        private string _login;
        private string _password;

        public bool IsCorrectUserData(string login, string password, string confirmPassword)
        {
            bool isLoginCorrect = login.Length > 0;
            bool isPaswordCorrect = password.Length > 0;
            bool isConfirmCorrect = password == confirmPassword;
            if (isLoginCorrect && isPaswordCorrect && isConfirmCorrect)
                return true;
            return false;
        }

        public int GetDaysCount(int month, int year)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException();
            int february = (year % 400 == 0 || year % 100 != 0 && year % 4 == 0;) ? 29:28;
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        }
    }
}
