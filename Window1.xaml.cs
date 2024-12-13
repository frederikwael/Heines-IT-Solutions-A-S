using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public partial class LoginWindow : Window
    {
        private readonly Dictionary<string, string> _credentials = new Dictionary<string, string>
        {
            { "Frederik", "123" },
            { "Adam", "234" },
            { "Kasper", "345" },
            { "Jesper", "456" },
            { "Jonathan", "567" }
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

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == "Brugernavn")
            {
                textBox.Text = string.Empty;
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Brugernavn";
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            ForgotPasswordWindow forgotPasswordWindow = new ForgotPasswordWindow
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            forgotPasswordWindow.ShowDialog();
        }
    }

    public class ForgotPasswordWindow : Window
    {
        public ForgotPasswordWindow()
        {
            Title = "Glemt Password";
            Width = 700;
            Height = 600;
        }
    }
}
