
using System.Collections.Generic;
using System.Windows;

namespace WpfApp
{
    public partial class EmployeeInfoWindow : Window
    {
        public EmployeeInfoWindow()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            var employees = new List<Employee>
            {
                new Employee { Navn = "Frederik", Timer = 40, Stilling = "Chef", M�dtFrav�r  = true },
                new Employee { Navn = "Adam", Timer = 38, Stilling = "Afdelingsleder", M�dtFrav�r = false },
                new Employee { Navn = "Kasper", Timer = 35, Stilling = "Ansat", M�dtFrav�r = true },
                new Employee { Navn = "Jesper", Timer = 42, Stilling = "Teamleder", M�dtFrav�r = true },
                new Employee { Navn = "Jonathan", Timer = 37, Stilling = "Ansat", M�dtFrav�r = false },
            };
            EmployeeDataGrid.ItemsSource = employees;
        }

        private void BackToMainMenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }

    public class Employee
    {
        public string Navn { get; set; }
        public int Timer { get; set; }
        public string Stilling { get; set; }
        public bool M�dtFrav�r { get; set; }

    }
}