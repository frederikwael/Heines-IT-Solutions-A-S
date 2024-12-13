using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenBingoBoardWindow(object sender, RoutedEventArgs e)
        {
            var bingoBoardWindow = new BingoBoardWindow
            {
                Left = this.Left, // Position the new window at the same location as the current window
                Top = this.Top
            };
            bingoBoardWindow.Show(); // Open Bingo Board Window
            this.Close(); // Close MainWindow
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow
            {
                Left = this.Left, // Position the new window at the same location as the current window
                Top = this.Top
            };
            loginWindow.Show(); // Open login window
            this.Close(); // Close the main menu
        }

        private void OpenEmployeeInfoWindow(object sender, RoutedEventArgs e)
        {
            var employeeInfoWindow = new EmployeeInfoWindow
            {
                Left = this.Left, // Position the new window at the same location as the current window
                Top = this.Top
            };
            employeeInfoWindow.Show(); // Open Employee Info Window
            this.Close(); // Close MainWindow
        }
    }
}
