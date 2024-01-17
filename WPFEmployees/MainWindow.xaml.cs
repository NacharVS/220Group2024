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

namespace WPFBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Employee
        {
            private string _name;
            private string _age;
            private string _mail;
            private string _city;
            public Employee(string name, string age, string mail, string city)
            {
                Name = name;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Age
            {
                get { return _age; }
                set { _age = value; }
            }
            public string Mail
            {
                get { return _mail; }
                set { _mail = value; }
            }
            public string City
            {
                get { return _city; }
                set { _city = value; }
            }
        }
        List<Employee> employees = new List<Employee> { };
        public MainWindow()
        {
                InitializeComponent();
        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void reg_btn_Click(object sender, RoutedEventArgs e)
        {
            employees.Add(new Employee(txtname.Text, txtage.Text, txtmail.Text, txtcity.Text));
            employees_list.Items.Clear();
            txtname.Clear();
            txtage.Clear();
            txtmail.Clear();
            txtcity.Clear();
            foreach (Employee employee in employees)
            {
                employees_list.Items.Add(employee.Name);
            }
        }

        private void employees_list_Selected(object sender, RoutedEventArgs e)
        {
            string sname = employees_list.SelectedItem.ToString();
            Employee emp = employees.Find(e => e.Name == sname);
            empName.Content = emp.Name;
        }

        private void employees_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
