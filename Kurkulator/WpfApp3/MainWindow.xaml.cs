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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float diff;
        float diff1;
        float result;
        String action;
        public MainWindow()
        {
            InitializeComponent();
            text_block.Content = "0";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "1";
            }
            else
            {
                text_block.Content += "1";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "2";
            }
            else
            {
                text_block.Content += "2";
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "3";
            }
            else
            {
                text_block.Content += "3";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "4";
            }
            else
            {
                text_block.Content += "4";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "5";
            }
            else
            {
                text_block.Content += "5";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "6";
            }
            else
            {
                text_block.Content += "6";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "7";
            }
            else
            {
                text_block.Content += "7";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "8";
            }
            else
            {
                text_block.Content += "8";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "9";
            }
            else
            {
                text_block.Content += "9";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (text_block.Content.ToString() == "0")
            {
                text_block.Content = "0";
            }
            else
            {
                text_block.Content += "0";
            }
        }

        private void button_cleaning_Click(object sender, RoutedEventArgs e)
        {
            text_block.Content = "0";
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            diff1 = Convert.ToInt32(text_block.Content);
            text_block.Content = "0";
            action = "+";
        }

        private void button_equality_Click(object sender, RoutedEventArgs e)
        {
            switch (action)
            {
                case "+": 
                    diff = Convert.ToInt32(text_block.Content);
                    text_block.Content = diff1 + diff;
                    action = "";
                    result = 0;
                    break;
                case "-":
                    diff = Convert.ToInt32(text_block.Content);
                    text_block.Content = diff1 - diff;
                    action = "";
                    result = 0;
                    break;
                case "*":
                    diff = Convert.ToInt32(text_block.Content);
                    text_block.Content = diff1 * diff;
                    action = "";
                    result = 0;
                    break;
                case "/":
                    diff = Convert.ToInt32(text_block.Content);
                    if (diff != 0)
                    {
                        text_block.Content = diff1 / diff;
                        action = "";
                        result = 0;
                    }
                    else
                    {
                        text_block.Content = "Ошибка";
                    }
                    break;
            }

            
        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            diff1 = Convert.ToInt32(text_block.Content);
            text_block.Content = "0";
            action = "-";
        }

        private void button_multiplication_Click(object sender, RoutedEventArgs e)
        {
            diff1 = Convert.ToInt32(text_block.Content);
            text_block.Content = "0";
            action = "*";
        }

        private void button_division_Click(object sender, RoutedEventArgs e)
        {
            diff1 = Convert.ToInt32(text_block.Content);
            text_block.Content = "0";
            action = "/";
        }
    }
}
