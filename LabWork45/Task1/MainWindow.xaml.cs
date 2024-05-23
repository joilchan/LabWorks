using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tasks_45;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ConnectionLabel.Content = DataAccessLayer.ConnectionString;

            try
            {
                BookListGrid.ItemsSource = DataAccessLayer.GetBookList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void GetValueButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ExcuteCommandLabel.Content = DataAccessLayer.GetValue(CommandTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GetTableButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TableGrid.ItemsSource = DataAccessLayer.GetTable(CommandTextBox2.Text).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LabWork46Button_Click(object sender, RoutedEventArgs e)
        {
            LabWork46Window labWork46Window = new LabWork46Window();
            labWork46Window.Show();
        }

        private void LabWork47Button_Click(object sender, RoutedEventArgs e)
        {
            LabWork47Window labWork47Window = new LabWork47Window();
            labWork47Window.Show();
        }

        private void LabWork48Button_Click(object sender, RoutedEventArgs e)
        {
            LabWork48Window labWork48Window = new LabWork48Window();
            labWork48Window.Show();
        }
    }
}