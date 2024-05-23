using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для LabWork48Window.xaml
    /// </summary>
    public partial class LabWork48Window : Window
    {
        public LabWork48Window()
        {
            InitializeComponent();
        }

        private void AddAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string surname = surnameTextBox.Text;
                string name = nameTextBox.Text;
                string country = countryTextBox.Text;

                DataAccessLayer.AddAuthor(surname, name, country);

                TablesGrid.ItemsSource = DataAccessLayer.GetAuthorTable().DefaultView;

                MessageBox.Show("Автор успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddAuthorButton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string surname = surnameTextBox1.Text;
                string name = nameTextBox1.Text;
                string country = countryTextBox1.Text;

                MessageBox.Show($"Автор успешно добавлен. ID: {DataAccessLayer.AddAuthorWithId(surname, name, country)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GetBookListButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int initialPrice = Convert.ToInt32(initialPriceTextBox.Text);
                int endPrice = Convert.ToInt32(endPriceTextBox.Text);

                TablesGrid.ItemsSource = DataAccessLayer.GetBookListPrice(initialPrice, endPrice).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
