using System;
using System.Windows;
using System.Windows.Controls;

namespace ForgotPasswordApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnResetPasswordClick(object sender, RoutedEventArgs e)
        {
            SecurityQuestionPanel.Visibility = Visibility.Visible;
            StatusMessage.Text = string.Empty;
        }

        private void OnSubmitClick(object sender, RoutedEventArgs e)
        {
            string answer = AnswerTextBox.Text.Trim();

            if (answer == "5")
            {
                StatusMessage.Foreground = System.Windows.Media.Brushes.Green;
                StatusMessage.Text = "Correct answer. Access granted.";
            }
            else
            {
                StatusMessage.Foreground = System.Windows.Media.Brushes.Red;
                StatusMessage.Text = "Incorrect answer. Try again.";
            }
        }
    }
    public class ForgotPasswordWindow : Window
    {
        public ForgotPasswordWindow()
        {
            Title = "Glemt Password";
            Width = 700;
            Height = 600;

            var grid = new Grid();
            this.Content = grid;

            var instructionText = new TextBlock
            {
                Text = "Indtast din e-mail",
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 100, 0, 0)
            };
            grid.Children.Add(instructionText);

            var emailTextBox = new TextBox
            {
                Width = 200,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 150, 0, 0)
            };
            grid.Children.Add(emailTextBox);

            var resetButton = new Button
            {
                Content = "Nulstil password",
                Width = 150,
                Height = 40,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 200, 0, 0)
            };
            grid.Children.Add(resetButton);
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
}
