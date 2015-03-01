using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppStart
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_SessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            String msg = String.Format("{0},是否退出程序？", e.ReasonSessionEnding);
            MessageBoxResult result = MessageBox.Show(msg, "Quit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (MessageBoxResult.No == result)
            {
                e.Cancel = true;
            }
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            if (e.Exception is NullReferenceException)
            {
                MessageBox.Show(e.Exception.Message+"(程序继续运行！)");
            }
            else
            {
                this.Shutdown(-1);
            }
        }
    }
}
