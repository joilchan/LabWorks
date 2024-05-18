using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new(DispatcherPriority.Render);
        int cookie = 0;
        int grandma = 0;
        int price = 15;

        public MainWindow()
        {
            InitializeComponent();

            timer.Tick += new(Timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();

            rectangle.IsEnabled = false;
            rectangle.Opacity = 0.5;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            PointsCount(1);
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PointsCount(1);
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PointsCount(-price);

            grandma++;
            grandmaLabel.Content = grandma;
            timer.Interval = TimeSpan.FromMilliseconds(1000 / (grandma + 1));
            timer.Start();
        }

        private void PointsCount(int addingCount)
        {
            cookie += addingCount;
            cookieLabel.Content = cookie;
            rectangle.IsEnabled = (cookie >= price);
            rectangle.Opacity = (cookie >= price) ? 1 : 0.5;
        }
    }
}