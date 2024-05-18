using LabWork16;

User user2 = new User();
user2.Notify += User_Notify;

user2.Login = "grisha";
user2.Login = "sasha";
user2.Password = "14234";

void User_Notify(object? sender, EventArgs e)
{
    User currentUser = sender as User;
    Console.WriteLine($"Изменены данные пользователя со следующим логином: {currentUser.Login}");
}