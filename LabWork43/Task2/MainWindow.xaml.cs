using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new(DispatcherPriority.Render);
        DispatcherTimer timerMove = new(DispatcherPriority.Render);

        int score = 0;
        Label scoreLabel = new();

        public MainWindow()
        {
            InitializeComponent();

            TimerStart(timer, 500);
            timer.Tick += Timer_Tick;

            TimerStart(timerMove, 50);
            timerMove.Tick += TimerMove_Tick;

            gameCanvas.Children.Add(scoreLabel);
            scoreLabel.Foreground = new SolidColorBrush(Colors.White);
            scoreLabel.Content = 0;
        }

        private void TimerMove_Tick(object? sender, EventArgs e)
        {
            foreach (Shape enemy in gameCanvas.Children.OfType<Shape>())
            {
                double positionY = (double)enemy.GetValue(Canvas.TopProperty);
                Canvas.SetTop(enemy, positionY + 3);
                if (positionY >= 400)
                {
                    timerMove.Stop();
                    MessageBox.Show("End");
                    break;
                }
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Ellipse enemy = new Ellipse
            {
                Width = 30,
                Height = 30,
                Fill = new SolidColorBrush(Colors.Maroon),
            };
            gameCanvas.Children.Add(enemy);

            double positionX = new Random().NextDouble() * Width;
            Canvas.SetLeft(enemy, positionX);
            Canvas.SetTop(enemy, -enemy.Height);

            enemy.MouseDown += Enemy_MouseDown;
        }

        private void Enemy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gameCanvas.Children.Remove(sender as UIElement);

            score++;
            scoreLabel.Content = score;
        }

        private void TimerStart(DispatcherTimer currentTimer, int milliseconds)
        {
            currentTimer.Interval = TimeSpan.FromMilliseconds(milliseconds);
            currentTimer.Start();
        }
    }
}