using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace EmployeesDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        EmployeeRepository employeeRepository = new EmployeeRepository();
        public MainWindow()
        {
            InitializeComponent();
            DataGridView1.ItemsSource = employeeRepository.GetAll();
        }


        private void saveEmployeeBtn(object sender, RoutedEventArgs e)
        {
            employeeRepository.Add(new Employee
            {
                FirstName = firstNameTxt.Text,
                LastName = lastNameTxt.Text,
            });
            DataGridView1.ItemsSource = employeeRepository.GetAll();
        }

        private void DataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
