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
using System.Xml.Linq;

namespace regis
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new List<User>();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User(Name.Text, Surname.Text, Phone_number.Text, E_mail.Text));
            ListAdd();
        }
        public void ListAdd()
        {
            spisochek.Items.Clear();
            foreach (var item in users)
            {
                spisochek.Items.Add(item.Name);
            }
        }


        private void surname_re(object sender, RoutedEventArgs e)
        {
            if (Surname.Text == "Фамилия")
            {
                Surname.Text = "";
            }
        }

        private void name_re(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "Имя")
            {
                Name.Text = "";
            }
        }

        private void phone_re(object sender, RoutedEventArgs e)
        {
            if (Phone_number.Text == "Телефон")
            {
                Phone_number.Text = "";
            }
        }

        private void email_re(object sender, RoutedEventArgs e)
        {
            if (E_mail.Text == "E-mail")
            {
                E_mail.Text = "";
            }
        }

        private void listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string usname = spisochek.SelectedValue.ToString();
            User us = users.Find(usk => usk.Name == usname);
            MessageBox.Show($"{us.Surname} \n" + $"{us.Name} \n" + $"{us.Phone_number} \n" + $"{us.Email} \n");

        }
    }
}