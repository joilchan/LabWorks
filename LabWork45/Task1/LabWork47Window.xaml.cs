using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для LabWork47Window.xaml
    /// </summary>
    public partial class LabWork47Window : Window
    {
        public LabWork47Window()
        {
            InitializeComponent();
        }

        private void bookPriceButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bookPriceLabel.Content = DataAccessLayer.GetBookPrice(Convert.ToInt32(userPriceTextBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InsertCommandButton_Click(object sender, RoutedEventArgs e)
        {
            string query = InsertCommandTextBox.Text;
            try
            {
                gameIdLabel.Content = $"ID добавленной записи: {DataAccessLayer.GetGameId(query)}";
                MessageBox.Show("Запись успешно добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ShowContentButton_Click(object sender, RoutedEventArgs e)
        {
            string genre = GenreTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);

            try
            {
                BookDataGrid.ItemsSource = DataAccessLayer.GetBookTable(price, genre).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
