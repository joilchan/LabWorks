using Microsoft.Win32;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Файл JPEG|*.jpeg, *.jpg|Файл PNG|*.png|Файл SVG|*.svg|Все файлы|*.*";
            openFileDialog.Title = "Выбор изображения";
            openFileDialog.InitialDirectory = @"C:\";

            if (openFileDialog.ShowDialog().Value != true)
                return;
            else
                image.Source = new BitmapImage(new Uri(openFileDialog.FileName));
        }

        private void BlackColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.Black);
        }

        private void RedColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.Red);
        }

        private void OrangeColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.Orange);
        }

        private void YellowColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.Yellow);
        }

        private void GreenColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.Green);
        }

        private void LightBlueColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.LightBlue);
        }

        private void BlueColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.Blue);
        }

        private void PurpleColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.Purple);
        }

        private void WhiteColorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor(Colors.White);
        }

        private void BrushSizeTen_Click(object sender, RoutedEventArgs e)
        {
            ChangeSize(10);
        }

        private void BrushSizeTwenty_Click(object sender, RoutedEventArgs e)
        {
            ChangeSize(20);
        }

        private void BrushSizeThirty_Click(object sender, RoutedEventArgs e)
        {
            ChangeSize(30);
        }

        private void BrushSizeFourty_Click(object sender, RoutedEventArgs e)
        {
            ChangeSize(40);
        }

        private void BrushSizeButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeSize(50);
        }

        private void ChangeSize(int size)
        {
            canvas.DefaultDrawingAttributes.Width = size;
        }

        private void ChangeColor(Color color)
        {
            canvas.DefaultDrawingAttributes.Color = color;
        }
    }
}