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

namespace WpfBase1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string action;
        public string number1;
        public bool clear;
        public MainWindow()
        {
            clear = false;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                clear = false;
                vvod.Text = "0";
            }
            Button button = (Button)sender;
            if (vvod.Text == "0")
            {
                vvod.Text = (string)button.Content;
            }
            else
            {
                vvod.Text += (string)button.Content;
            }

        }
        private void btn_action_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            action = (string)btn.Content;
            number1 = vvod.Text;
            clear = true;
        }

        private void btn_ravno_Click(object sender, RoutedEventArgs e)
        {
            double dNumber1, dNumber2, result;
            result = 0;
            dNumber1 = Convert.ToDouble(number1);
            dNumber2 = Convert.ToDouble(vvod.Text);
            if (action == "+")
            {
                result = dNumber1 + dNumber2;
            }
            if (action == "-")
            {
                result = dNumber1 - dNumber2;
            }
            if (action == "*")
            {
                result = dNumber1 * dNumber2;
            }
            if (action == "/")
            {
                if (dNumber2 == 0)
                {
                    vvod.Text = "Ошибка";
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    result = dNumber1 / dNumber2;
                }
            }
            action = "=";
            clear = true;
            vvod.Text = result.ToString();
        }
        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            vvod.Text = "0";
        }

    }
}
