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

namespace WphRwgistration
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
            users.Add(new User(name.Text, surname.Text, phone_number.Text, E_mail.Text));
            ListBoxAdd();
        }
        public void ListBoxAdd()
        {
            listbox.Items.Clear();
            foreach (var item in users)
            {
                listbox.Items.Add(item.Name);
            }
        }
    }
}
