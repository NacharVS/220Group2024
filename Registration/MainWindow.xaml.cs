using Registration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Registration
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
            //var globalNames = Name.Text;
            //var globalSurnames = Surname.Text;
            //var globalEmail = Email.Text;
        }

        private void regestratoin_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User(Name.Text, Surname.Text, Age.Text, Email.Text));
            ListBoxRefresh();
            Name.Clear();
            Name.Text = "Имя";
            Surname.Clear();
            Surname.Text = "Фамилия";
            Age.Clear();
            Age.Text = "Возраст";
            Email.Clear();
            Email.Text = "Почта";
        }
        private void ListBoxRefresh()
        {
            listbox.Items.Clear();
            foreach (var item in users)
            {
                listbox.Items.Add(item.Name);
            }
        }
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string selectedName = listBox.SelectedItem.ToString();
                User selectedUser = users.FirstOrDefault(u => u.Name == selectedName);
            }
            if (selectedUser != null)
            {
                Label.Content = ($"Имя: {selectedUser.Name},\nФамилия: {selectedUser.Surname}, \nВозраст: {selectedUser.Age}, \nEmail: {selectedUser.Email}");
                
            }   
        }
        private void listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

    }
}






