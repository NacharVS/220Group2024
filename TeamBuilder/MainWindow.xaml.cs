﻿using System;
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
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new List<User>();
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listbox1_Loaded(object sender, RoutedEventArgs e)
        {
            //listbox1.ItemsSource = User.GetUsersNames();
            //foreach (var item in User.GetUsers())
            //{
            //    listbox1.Items.Add(item.Name);
            //}
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User(txtName.Text, txtSurname.Text, txtAge.Text, txtEmail.Text));
            ListBoxRefresh();
            txtName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            txtEmail.Clear();
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

        }
    }
}
