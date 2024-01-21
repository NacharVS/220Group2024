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

namespace WpfApp2
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

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
                users.Add(new User(UserNameTB.Text, SurnameTB.Text, AgeTB.Text, EmailTB.Text));
                ListBoxRefresh();
                UserNameTB.Clear();
                UserNameTB.Text = "Имя";
                SurnameTB.Clear();
                SurnameTB.Text = "Фамилия";
                AgeTB.Clear();
                AgeTB.Text = "Возраст";
                EmailTB.Clear();
                EmailTB.Text = "Email";
        }

        private void ListBoxRefresh()
        {
            AddPeopleListBox.Items.Clear();
            foreach (var item in users)
            {
                AddPeopleListBox.Items.Add(item);
            }
        }

        private void AddPeopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = AddPeopleListBox.SelectedItem as User;
            if (item != null)
            {
                InfoLabel.Content = ("Имя: " + item.Name + Environment.NewLine + "Фамилия: " + item.Surname + Environment.NewLine + "Возраст: " + item.Age + Environment.NewLine + "Email: " + item.Email);
            }
        }
    }
}
