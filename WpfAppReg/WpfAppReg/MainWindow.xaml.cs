using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace WpfAppReg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public class Employee
        {
            public string Mail {  get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Age {  get; set; }

            public Employee(string _mail, string _name, string _lastname, string _age)
            {
                Mail = _mail;
                Name = _name;
                LastName = _lastname;
                Age = _age;
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee> { };
        List<Employee> employees_buffer = new List<Employee> { };

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            employees.Add(new Employee(Mailtext.Text, Nametext.Text, LastNametext.Text, Agetext.Text));
            employees_buffer.Add(new Employee(Mailtext.Text, Nametext.Text, LastNametext.Text, Agetext.Text));
            Mailtext.Clear();
            Nametext.Clear();
            LastNametext.Clear();
            Agetext.Clear();
            foreach (Employee employee in employees_buffer)
            {
                List1.Items.Add(employee.Name);
            }
            employees_buffer.Clear();
        }
        private void List1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string sname = List1.SelectedValue.ToString();
            Employee emp = employees.Find(es => es.Name == sname);
            Mailres.Content = "Mail: " + emp.Mail;
            Nameres.Content = "Name: " + emp.Name;
            Lastnameres.Content = "Lastname: " + emp.LastName;
            Ageres.Content = "Age: " + emp.Age;
        }

        private void List1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string sname = List1.SelectedValue.ToString();
            Employee emp = employees.Find(es => es.Name == sname);
            Mailres.Content = "Mail: " + emp.Mail;
            Nameres.Content = "Name: " + emp.Name;
            Lastnameres.Content = "Lastname: " + emp.LastName;
            Ageres.Content = "Age: " + emp.Age;
        }

        private void Agetext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Nametext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
