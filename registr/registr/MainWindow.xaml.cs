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

namespace registr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<user> users = new List<user>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clck(object sender, RoutedEventArgs e)
        {
            users.Add(new user(name.Text, surname.Text, otchestvo.Text, phone.Text, email.Text));
            listik.Items.Clear();
            foreach(var i in users)
            {
                listik.Items.Add(i.Name);
            }
            
        }

        private void listik_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            user user1 = users.Find(em => em.Name == listik.SelectedValue.ToString());
            MessageBox.Show($"{user1.Name}\n{user1.Surname}\n{user1.Otchestvo}\n{user1.Phone}\n{user1.Email}");
        }
    }
}
