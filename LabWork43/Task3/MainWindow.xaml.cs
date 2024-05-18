using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timerMove = new(DispatcherPriority.Render);
        Point point;
        int count = 0;

        public MainWindow()
        {
            InitializeComponent();

            Ellipse ball = new Ellipse
            {
                Width = 20,
                Height = 20,
                Fill = new SolidColorBrush(Colors.Maroon),
            };
            canvas.Children.Add(ball);

            double positionX = new Random().NextDouble() * 800;
            double positionY = new Random().NextDouble() * 200;
            Canvas.SetLeft(ball, positionX);
            Canvas.SetTop(ball, positionY);

            timerMove.Interval = TimeSpan.FromMilliseconds(1);
            timerMove.Start();
            timerMove.Tick += TimerMove_Tick;
        }

        private void TimerMove_Tick(object? sender, EventArgs e)
        {
            label.Content = count++;


        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left && Canvas.GetLeft(racket) > 0)
            {
                Canvas.SetLeft(racket, Canvas.GetLeft(racket) - 10);
            }
            if (e.Key == Key.Right && Canvas.GetLeft(racket) < canvas.ActualWidth - racket.ActualWidth)
            {
                Canvas.SetLeft(racket, Canvas.GetLeft(racket) + 10);
            }
        }
    }
}