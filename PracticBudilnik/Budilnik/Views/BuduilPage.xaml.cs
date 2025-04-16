using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            timerbudilnik = new DispatcherTimer();
            timerbudilnik.Interval = TimeSpan.FromSeconds(1);


        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
