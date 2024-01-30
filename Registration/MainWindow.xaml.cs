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
            Name.GotFocus += RemoveText;
            Name.LostFocus += AddText;
            Name.Text = "Имя...";

            Surname.GotFocus += RemoveText;
            Surname.LostFocus += AddText;
            Surname.Text = "Фамилия...";

            Age.GotFocus += RemoveText;
            Age.LostFocus += AddText;
            Age.Text = "Возраст...";

            Email.GotFocus += RemoveText;
            Email.LostFocus += AddText;
            Email.Text = "Почта...";

            

            //var globalNames = Name.Text;
            //var globalSurnames = Surname.Text;
            //var globalEmail = Email.Text;
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            // Удаляем текст-подсказку при фокусировке текстового поля
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == textBox.Tag as string)
            {
                textBox.Text = "";
            }
        }
        private void AddText(object sender, RoutedEventArgs e)
        {
            // Добавляем текст-подсказку обратно, если поле пустое
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag as string;
            }
        }

        private void ListBoxRefresh()
        {
            listbox.Items.Clear();
            foreach (var item in users)
            {
                listbox.Items.Add(item.Name);
            }
        }
        

        private void listbox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                User selectedUser = users.FirstOrDefault(u => u.Name == listbox.SelectedItem.ToString());

                // После получения выбранного пользователя вы можете отобразить его данные
                if (selectedUser != null)
                {
                   label.Content = $"Имя: {selectedUser.Name},\nФамилия: {selectedUser.Surname},\nВозраст: {selectedUser.Age},\nEmail: {selectedUser.Email}";
                }
            }
        }

        private void regestration_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User(Name.Text, Surname.Text, Age.Text, Email.Text));
            ListBoxRefresh();
            Name.Clear();
            Name.Text = "Имя...";
            Surname.Clear();
            Surname.Text = "Фамилия...";
            Age.Clear();
            Age.Text = "Возраст...";
            Email.Clear();
            Email.Text = "Почта...";
        }

    }
}






