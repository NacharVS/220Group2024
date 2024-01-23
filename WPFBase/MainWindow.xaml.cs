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
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new List<User>();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User(txt1.Text, txtAge.Text, txtSurname.Text, txtEmail.Text));
            ListBoxRefresh();
            txt1.Clear();
            txtAge.Clear();
            txtSurname.Clear();
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

        private void DataOutput_Click(object sender, RoutedEventArgs e)
        {
            User user1 = users.Find(pon => pon.Name == listbox1.SelectedValue.ToString());
            MessageBox.Show($"Имя: {user1.Name}\n Возраст: {user1.Age}\n Фамилия: {user1.Surname}\n Email: {user1.Email}");
        }
    }
}
