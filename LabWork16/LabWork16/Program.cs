using LabWork16;
using System.ComponentModel;

User user = new User();
user.PropertyChanged += User_PropertyChanged;

user.Login = "joil";
user.Login = "meow";
user.Password = "1234";

void User_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"Изменилось свойство {e.PropertyName}");
}