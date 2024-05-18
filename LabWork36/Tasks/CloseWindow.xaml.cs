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

namespace Tasks
{
    /// <summary>
    /// Логика взаимодействия для CloseWindow.xaml
    /// </summary>
    public partial class CloseWindow : Window
    {
        public CloseWindow()
        {
            InitializeComponent();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
