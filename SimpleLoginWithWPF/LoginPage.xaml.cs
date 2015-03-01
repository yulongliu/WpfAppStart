using SimpleLoginWithWPF.Models;
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

namespace SimpleLoginWithWPF
{
    /// <summary>
    /// LoginPage.xaml 的交互逻辑
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            List<UserModel> userList = ((App)(App.Current)).userList;
            String userName = txtUserName.Text;
            String userPwd = PwdUserPwd.Password;
            var user = userList.FirstOrDefault(u => u.Name == userName && u.Password == userPwd);
            if (user!=null)
            {
                WelcomePage welPage = new WelcomePage(user);
                NavigationService.Navigate(welPage);
                return;
            }
            else
            {
                MessageBox.Show("用户名不存在或密码错误！");
                PwdUserPwd.Clear();
            }
        }
    }
}
