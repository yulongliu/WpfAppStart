using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace WpfAppNavigationWithPage
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            NavigationWindow navigatedWin = new NavigationWindow();
            navigatedWin.Content = new FirstPage();
            navigatedWin.Show();
        }

        private void Application_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);

            e.Handled = true;
        }

        private void Application_Navigated(object sender, NavigationEventArgs e)
        {
            Console.WriteLine(e.Content.ToString());
        }

        private void Application_NavigationProgress(object sender, NavigationProgressEventArgs e)
        {
            Console.WriteLine(e.Uri.ToString());
        }

        private void Application_NavigationStopped(object sender, NavigationEventArgs e)
        {

        }

        private void Application_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }

        private void Application_FragmentNavigation(object sender, FragmentNavigationEventArgs e)
        {

        }
    }
}
