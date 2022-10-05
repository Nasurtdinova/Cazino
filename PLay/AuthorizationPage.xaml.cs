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

namespace PLay
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = new List<User>(BdConnection.Connection.User.ToList());
            if (users.Where(a => a.Login == tbLogin.Text && a.Password == tbPassword.Password).ToList().Count == 0)
            {
                MessageBox.Show("!!!");
            }
            else
            {
                MainWindow.CurrentUser = users.Where(a => a.Login == tbLogin.Text && a.Password == tbPassword.Password).FirstOrDefault();
                NavigationService.Navigate(new CasinoPage());
            }
        }

        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
