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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Budilnik.Views
{
    /// <summary>
    /// Логика взаимодействия для TimerPage.xaml
    /// </summary>
    public partial class TimerPage : Page
    {
        private DispatcherTimer _timer;
        private TimeSpan _timeLeft;

        public TimerPage()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1); // Тик каждую секунду
            _timer.Tick += Timer_Tick;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            int timertb = int.Parse(TBTimerOn.Text.ToString());
            _timeLeft = TimeSpan.FromMinutes(timertb); // например, отсчет с 1 минуты
            TimerText.Text = _timeLeft.ToString(@"mm\:ss");
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_timeLeft > TimeSpan.Zero)
            {
                _timeLeft = _timeLeft.Subtract(TimeSpan.FromSeconds(1));
                TimerText.Text = _timeLeft.ToString(@"mm\:ss");
            }
            else
            {
                _timer.Stop();
                TimerText.Text = "Время вышло!";
                MessageBox.Show("Таймер завершён!");
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
