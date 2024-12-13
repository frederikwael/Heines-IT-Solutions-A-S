using System.Windows;

namespace WpfApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Start med LoginWindow
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}

