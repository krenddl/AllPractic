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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        User contextUser;
        public  Page2(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;
            cmbRole.ItemsSource = AppData.db.Role.ToList();

        }

        private void BtnCancel2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void BtnAdd2(object sender, RoutedEventArgs e)
        {
            AppData.db.User.Add(contextUser);
            AppData.db.SaveChanges();
            NavigationService.GoBack();


        }
    }
}
