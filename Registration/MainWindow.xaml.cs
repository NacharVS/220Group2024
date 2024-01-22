using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Human> HumanCollection { get; set; } = new ObservableCollection<Human>();
        public MainWindow()
        {
            InitializeComponent();
            namelist.ItemsSource = HumanCollection;
        }

        private void surnameTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            surname.Text = string.Empty;
        }

        private void Email_GotFocus(object sender, RoutedEventArgs e)
        {
            email.Text = string.Empty;
        }

        private void Numder_GotFocus(object sender, RoutedEventArgs e)
        {
            numder.Text = string.Empty;
        }

        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            name.Text = string.Empty;
        }


        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {

            
            if (email.Text.Contains("@") && email.Text.Contains(".") &&
                surname.Text.Length > 3 && name.Text.Length > 3)
            {
                if ((HumanCollection.Any(h => h.Email == email.Text)) == false)
                {
                    Human hum = new Human()
                    {
                        Email = email.Text,
                        Surname = surname.Text,
                        Name = name.Text,
                        Number = numder.Text
                    };

                    HumanCollection.Add(hum);
                    namelist.ItemsSource = HumanCollection;

                }
                else
                {
                    MessageBox.Show("Пользователь с таким email уже зарегистрирован!", "Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
            else
            {
                
                MessageBox.Show("Что-то пошло не так!");
            }
        }

        private void namelist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (namelist.SelectedItem != null)
            {
                Human human = namelist.SelectedItem as Human;
                MessageBox.Show($"{human.Surname}\n{human.Name}\n{human.Number}\n{human.Email}\n", "Полная информация");
            }
        }
    }
}
