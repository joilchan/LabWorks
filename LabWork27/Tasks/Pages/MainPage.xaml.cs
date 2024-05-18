using System.Windows;
using System.Windows.Controls;

namespace Tasks.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.AuthorizationPage());
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.RegistrationPage());
        }

        private void OptionButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.OptionPage());
        }
    }
}
