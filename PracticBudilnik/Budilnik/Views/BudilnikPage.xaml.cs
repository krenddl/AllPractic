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

namespace Budilnik.Views
{
    /// <summary>
    /// Логика взаимодействия для BudilnikPage.xaml
    /// </summary>
    public partial class BudilnikPage : Page
    {
        public BudilnikPage()
        {
            InitializeComponent();
        }

        private void Budilnik_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BuduilPage());
        }

        private void TimerBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TimerPage());
        }
    }
}
