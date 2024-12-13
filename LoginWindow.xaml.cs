using System.Collections.Generic;
using System.Windows;

namespace WpfApp
{
    public partial class LoginWindow : Window
    {
        private readonly Dictionary<string, string> _credentials = new Dictionary<string, string>
        {
            { "Frederik", "1" },
            { "Adam", "2" },
            { "Kasper", "3" },
            { "Jesper", "4" },
            { "Jonathan", "5" }
        };

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Password;

            if (_credentials.TryGetValue(username, out string correctPassword) && correctPassword == password)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                ErrorText.Text = "Ugyldigt brugernavn eller adgangskode.";
                ErrorText.Visibility = Visibility.Visible;
            }
        }
    }
}