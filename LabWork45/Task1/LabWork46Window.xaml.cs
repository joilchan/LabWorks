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
using Task1;

namespace Tasks_45
{
    /// <summary>
    /// Логика взаимодействия для LabWork46Window.xaml
    /// </summary>
    public partial class LabWork46Window : Window
    {
        public LabWork46Window()
        {
            InitializeComponent();
        }

        private void ChangeRowsButton_Click(object sender, RoutedEventArgs e)
        {
            ChangedRowsLabel.Content = DataAccessLayer.ChangeTable(ChangedRowsTextBox.Text).ToString();
        }

        private void ChangePriceButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResultLabel.Content = DataAccessLayer.ChangePrice(Convert.ToInt32(PriceTextBox.Text), Convert.ToInt32(IdTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tableButton_Click(object sender, RoutedEventArgs e)
        {
            string table = tableTextBox.Text;
            try
            {
                tableDataGrid.ItemsSource = DataAccessLayer.GetDataTable(table).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
