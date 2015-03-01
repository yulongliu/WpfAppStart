using SimpleLoginWithWPF.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace SimpleLoginWithWPF
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public List<UserModel> userList;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            userList = new List<UserModel>();
            UserModel dragonliu = new UserModel("dragonliu", "123456");
            dragonliu.Hobbies.Add("看小说");
            dragonliu.Hobbies.Add("吃美食");
            userList.Add(dragonliu);

            NavigationWindow win = new NavigationWindow();
            win.Width = 500;
            win.Height = 600;
            win.Content = new LoginPage();
            win.Show();
        }
    }
}
