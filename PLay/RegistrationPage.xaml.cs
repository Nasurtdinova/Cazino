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
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnREgistr_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Login = tbLogin.Text,
                Password = tbPassword.Password,
                Name = tbName.Text,
                Score = 0
            };

            BdConnection.Connection.User.Add(user);
            BdConnection.Connection.SaveChanges();
            MessageBox.Show("Вы зарегистрированы!");
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
