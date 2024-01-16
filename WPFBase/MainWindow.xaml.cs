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
        List<double> buffer = new List<double> { };
        string buffer2;
        List<string> action = new List<string> { };
        double result = 0;
        bool points = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "2";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            res.Content += "5";
        }

        private void one_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "1";
        }

        private void three_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "3";
        }

        private void four_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "4";
        }

        private void six_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "6";
        }

        private void seven_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "7";
        }

        private void eight_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "8";
        }

        private void nine_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "9";
        }

        private void zero_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content += "0";
        }

        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            res.Content = "";
            buffer.Clear();
            action.Clear();
        }

        private void backsp_ptn_Click(object sender, RoutedEventArgs e)
        {
            if (res.Content != "")
            {
                res.Content = res.Content.ToString()[..^1];
            }
        }

        private void plus_btn_Click(object sender, RoutedEventArgs e)
        {
            if (res.Content != "")
            {
                buffer2 = res.Content.ToString();
                buffer.Add(Convert.ToDouble(res.Content));
                res.Content = "";
                action.Add("+");
                points = false;
            }
        }

        private void minus_btn_Click(object sender, RoutedEventArgs e)
        {
            if (res.Content != "")
            {
                buffer2 = res.Content.ToString();
                buffer.Add(Convert.ToDouble(res.Content));
                res.Content = "";
                action.Add("-");
                points = false;
            }
        }

        private void div_btn_Click(object sender, RoutedEventArgs e)
        {
            if (res.Content != "")
            {
                buffer2 = res.Content.ToString();
                buffer.Add(Convert.ToDouble(res.Content));
                res.Content = "";
                action.Add("/");
                points = false;
            }
        }
        private void mult_btn_Click(object sender, RoutedEventArgs e)
        {
            if (res.Content != "")
            {
                buffer2 = res.Content.ToString();
                buffer.Add(Convert.ToDouble(res.Content));
                res.Content = "";
                action.Add("*");
                points = false;
            }
        }

        private void enter_btn_Click(object sender, RoutedEventArgs e)
        {
            buffer.Add(Convert.ToDouble(res.Content));
            result = buffer[0];
            for (int i = 1; i < buffer.Count; i++)
            {

                if (action[i-1] == "+")
                {
                    result += buffer[i];
                    res.Content = result;
                }
                if (action[i-1] == "-")
                {
                    result -= buffer[i];
                    res.Content = result;
                }
                if (action[i-1] == "*")
                {
                    result *= buffer[i];
                    res.Content = result;
                }
                if (action[i-1] == "/")
                {
                    result /= buffer[i];
                    res.Content = result;
                }
                buffer2 = "";
            }
            action.Clear();
            buffer.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (points == false)
                res.Content += ",";
                points = true;
        }
    }
}
