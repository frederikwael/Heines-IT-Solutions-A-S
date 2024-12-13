
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
                new Employee { Navn = "Frederik", Timer = 40, Stilling = "Chef", MødtFravær  = true },
                new Employee { Navn = "Adam", Timer = 38, Stilling = "Afdelingsleder", MødtFravær = false },
                new Employee { Navn = "Kasper", Timer = 35, Stilling = "Ansat", MødtFravær = true },
                new Employee { Navn = "Jesper", Timer = 42, Stilling = "Teamleder", MødtFravær = true },
                new Employee { Navn = "Jonathan", Timer = 37, Stilling = "Ansat", MødtFravær = false },
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
        public bool MødtFravær { get; set; }

    }
}