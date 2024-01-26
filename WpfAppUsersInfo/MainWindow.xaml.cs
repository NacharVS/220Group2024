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

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Users> user = new List<Users> { };
        List<Users> users_zap = new List<Users> { };

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            var newUser = new Users(nameTextBox.Text, surnameTextBox.Text, ageTextBox.Text, emailTextBox.Text, genderComboBox.Text);
            user.Add(newUser);
            users_zap.Add(newUser);
            nameTextBox.Clear();
            surnameTextBox.Clear();
            ageTextBox.Clear();
            emailTextBox.Clear();
            genderComboBox.SelectedIndex = -1;
            foreach (var item in users_zap)
            {
                userListBox.Items.Add(item.Name);
            }
            users_zap.Clear();
        }
        private void UserListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string theus = userListBox.SelectedValue.ToString();
            Users stroka = user.Find(e => e.Name == theus);
            labelName.Content = "Имя: " + stroka.Name;
            labelSurName.Content = "Фамилия: " + stroka.Surname;
            labelAge.Content = "Возраст: " + stroka.Age;
            labelEmail.Content = "Email: " + stroka.Email;
            labelGender.Content = "Пол: " + stroka.Gender;
        }
    }
    public class Users
    {
        private string _name;
        private string _surName;
        private string _age;
        private string _email;
        private string _gender;
        public Users(string name, string surName, string age, string email, string gender)
        {
            Name = name;
            Surname = surName;
            Age = age;
            Email = email;
            Gender = gender;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surName; } set { _surName = value; } }
        public string Age { get { return _age; } set { _age = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
    }
}
