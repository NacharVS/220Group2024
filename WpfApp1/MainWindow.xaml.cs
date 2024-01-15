using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Number1 {  get; set; }
        public double Number2 { get; set; }
        public string Sign { get; set; } 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var num = sender as Button;
            if (Convert.ToInt64(Label1.Content)* Convert.ToInt64(Label1.Content) == 0)
            {
                Label1.Content = num.Content.ToString();

            }
            else
            {
                Label1.Content += num.Content.ToString();
            }
        }

        private void ButtonZn_Click(object sender, RoutedEventArgs e)
        {
            Number1 = Convert.ToInt64(Label1.Content);
            Label1.Content = null;

            var zn = sender as Button;
            Label1.Content = zn.Content.ToString();

            switch (Label1.Content)
            {
                case "+":
                    Sign = "+";
                    break;

                case "-":
                    Sign = "-";
                    break;

                case "*":
                    Sign = "*";
                    break;

                case "/":
                    Sign = "/";
                    break;
            }
            Label1.Content = null;
        }

        private void ButtonRvn_Click(object sender, RoutedEventArgs e)
        {
            Number2 = Convert.ToInt64(Label1.Content);

            if (Sign == "+") { Label1.Content = Number1 + Number2; }

            else if (Sign == "-") { Label1.Content = Number1 - Number2; }
            
            else if (Sign == "*") { Label1.Content = Number1 * Number2; }
            
            else { Label1.Content = Number1 / Number2; }
           
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            Label1.Content = 0;
        }
    }
}
