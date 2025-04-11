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
using Users.Models;

namespace Users
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void BtnAdd(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2(new User()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UsersGrid.ItemsSource = AppData.db.User.ToList();

        }

        private void BtnDel(object sender, RoutedEventArgs e)
        {
            var CurrentUser = UsersGrid.SelectedItem as User;
            AppData.db.User.Remove(CurrentUser);
            AppData.db.SaveChanges();

            UsersGrid.ItemsSource = AppData.db.User.ToList();
        }

        private void BtnEdit(object sender, RoutedEventArgs e)
        {
           if(UsersGrid.SelectedItem is User user)
            {
                NavigationService.Navigate(new Page2(user));
            }
        }
    }
}
