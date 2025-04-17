using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
    /// Логика взаимодействия для BuduilPage.xaml
    /// </summary>
    public partial class BuduilPage : Page
    {
        private DispatcherTimer timerbudilnik;
        private TimeSpan alarmbudilnik;
        private bool Setalarmbudilnik;

        public BuduilPage()
        {

            InitializeComponent();
            InitTimePickers();
            timerbudilnik = new DispatcherTimer();
            timerbudilnik.Interval = TimeSpan.FromSeconds(1);
            timerbudilnik.Tick += Timer_Tick;
            timerbudilnik.Start();


        }

        private void InitTimePickers()
        {
            for (int i = 0; i < 24; i++)
            {
                HoursCb.Items.Add(i.ToString("00"));
            }
            for (int i = 0; i < 60; i++)
            {
                MinutesCb.Items.Add(i.ToString("00"));
            }
            HoursCb.SelectedIndex = DateTime.Now.Hour;
            MinutesCb.SelectedIndex = DateTime.Now.Minute;
        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (HoursCb.SelectedItem == null || MinutesCb.SelectedItem == null)
            {
                MessageBox.Show("Время выбери пожалуйста");
                return;
            }
            
            int hour = int.Parse(HoursCb.SelectedItem.ToString());
            int minute = int.Parse(MinutesCb.SelectedItem.ToString());
            alarmbudilnik = new TimeSpan(hour, minute, 0);
            Setalarmbudilnik = true;
            TBBudil.Text = $"Будильник установлен на {DPBudil.SelectedDate:dd:MM:yyyy} {HoursCb.SelectedItem}:{MinutesCb.SelectedItem}";

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            DateTime nextAlarmDateTime = DateTime.Today + alarmbudilnik;

            // Если текущее время уже прошло время будильника на сегодня, устанавливаем на следующий день
            if (now > nextAlarmDateTime)
            {
                nextAlarmDateTime = nextAlarmDateTime.AddDays(1);
            }

            // Если будильник сработал
            if (Setalarmbudilnik && now.Hour == alarmbudilnik.Hours && now.Minute == alarmbudilnik.Minutes && now.Second == 0)
            {
                Setalarmbudilnik = false;
                TBBudil.Text = "Вставай, мое солнышко!";
                MessageBox.Show("ТрррТрррТррр");

                // Обновляем время на следующий будильник
                nextAlarmDateTime = nextAlarmDateTime.AddDays(1);  // Устанавливаем время для следующего дня
                Setalarmbudilnik = true;
            }

            // Если будильник установлен, обновляем отчет времени до следующего звонка
            if (Setalarmbudilnik)
            {
                TimeSpan timeLeft = nextAlarmDateTime - now;

                // Обновляем отчет о времени до следующего звонка
                TBBudilOtchet.Text = $"До звонка: {timeLeft:hh\\:mm\\:ss}";
                TBBudil.Text = $"Следующий звонок в: {nextAlarmDateTime:HH:mm:ss}";
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
