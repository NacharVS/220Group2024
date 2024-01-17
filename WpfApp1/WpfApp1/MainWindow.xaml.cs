using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfAppCulc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public double num1;
        public double num2;
        public string sign;
        private void Button_ClickNum(object sender, RoutedEventArgs e)
        {
            var num = sender as Button;
            if (Convert.ToInt64(Window.Content) * Convert.ToInt64(Window.Content) == 0)
            {
                Window.Content = num.Content.ToString();
            }
            else
            {
                Window.Content += num.Content.ToString();
            }

        }

        private void Button_ClickAlg(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToInt64(Window.Content);
            Window.Content = null;
            var alg = sender as Button;

            switch (Window.Content)
            {
                case "+":
                    sign = "+";
                    break;
                case "-":
                    sign = "-";
                    break;
                case "*":
                    sign = "*";
                    break;
                case "/":
                    sign = "/";
                    break;
            }

        }

        private void ButtonRavno_Click(object sender, RoutedEventArgs e)
        {

            num2 = Convert.ToInt64(Window.Content);
            if (sign == "+") { Window.Content = num1 + num2; }
            else if (sign == "-") { Window.Content = num1 - num2; }
            else if (sign == "/") { Window.Content = num1 / num2; }
            else { Window.Content = num1 * num2; }
        }

        private void Button_ClickZero(object sender, RoutedEventArgs e)
        {
            Window.Content = 0;
        }
    }
}