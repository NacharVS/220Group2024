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

namespace WpfRegistration
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
        //private void listbox1_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //listbox1.ItemsSource = User.GetUsersNames();
        //    //foreach (var item in User.GetUsers())
        //    //{
        //    //    listbox1.Items.Add(item.Name);
        //    //}
        //}

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User(txtName.Text, txtAge.Text, txtGender.Text, txtNumber.Text));
            ListBoxRefresh();
            txtName.Clear();
            txtAge.Clear();
            txtGender.Clear();
            txtNumber.Clear();
        }

        private void ListBoxRefresh()
        {
            listbox1.Items.Clear();
            foreach (var item in users)
            {
                listbox1.Items.Add(item.Name);
            }
        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = listbox1.SelectedValue.ToString();
            //User us = null;
            //foreach (var user in users)
            //{
            //    if (user.Name == name)
            //    {
            //        us = user;
            //        break;
            //    }
            //}
            User us = users.Find(x => x.Name == name);
            MessageBox.Show($"Name: {us.Name}\n" +
                $"Age: {us.Age}\n" +
                $"Gender: {us.Gender} \n" +
                $"Number: {us.Number}");
        }
    }
}
