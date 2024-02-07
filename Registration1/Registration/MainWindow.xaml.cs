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

namespace Registration
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> Users;
        public MainWindow()
        {
            InitializeComponent();
            Users = new List<User>();
            name.GotFocus += RemoveText;
            name.LostFocus += AddText;
            name.Text = "Имя";

            surname.GotFocus += RemoveText;
            surname.LostFocus += AddText;
            surname.Text = "Фамилия";

            phone__number.GotFocus += RemoveText;
            phone__number.LostFocus += AddText;
            phone__number.Text = "Телефон";

            email.GotFocus += RemoveText;
            email.LostFocus += AddText;
            email.Text = "Почта";
        }
        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == textBox.Tag as string)
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }
        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag as string;
                textBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8E8E8E"));
            }
        }

        private void ListBoxRefresh()
        {
            listbox.Items.Clear();
            foreach (var item in Users)
            {
                listbox.Items.Add(item.Name);
            }
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                User selectedUser = Users.FirstOrDefault(u => u.Name == listbox.SelectedItem.ToString());
                if(selectedUser != null)
                {
                    MessageBox.Show($"Имя: {selectedUser.Name}\n Фамилия: {selectedUser.Surname}\n Телефон: {selectedUser.PhoneNumber}\n Email: {selectedUser.Email}\n" );
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users.Add(new User(name.Text, surname.Text, phone__number.Text, email.Text));
            ListBoxRefresh();
            name.Clear();
            name.Text = "Имя";
            surname.Clear();
            surname.Text = "Фамилия";
            phone__number.Clear();
            phone__number.Text = "Телефон";
            email.Clear();
            email.Text = "Почта";
        }
    }
}
