using Microsoft.Win32;
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
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выбор изображения";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog().Value != true)
                return;
            else
            {
                timer.Interval = TimeSpan.FromSeconds(0.3);
                timer.Start();
            }

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
        }
    }
}