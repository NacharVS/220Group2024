using System;
using System.Collections.Generic;
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

namespace WpfCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Sign { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var num = sender as Button;
            string interimresult = Convert.ToString(Number2);

            if (Number1 == 0)
            {
                if (Convert.ToInt64(Label1.Content) * Convert.ToInt64(Label1.Content) == 0)
                {
                    Label1.Content = num.Content.ToString();
                }
                else
                {
                    Label1.Content += num.Content.ToString();
                }
            }
            else
            {
                Label1.Content = null;
                if (interimresult == "0")
                {
                    interimresult = Convert.ToString(num.Content);
                    Number2 = Convert.ToInt64(interimresult);
                    Label1.Content = interimresult;
                }
                else
                {
                interimresult += Convert.ToString(num.Content);
                Number2 = Convert.ToInt64(interimresult);
                Label1.Content = interimresult;
                }
            }
        }

        private void ButtonZn_Click(object sender, RoutedEventArgs e)
        {
            var zn = sender as Button;

            if (Number1 == 0)
             {
                Number1 = Convert.ToInt64(Label1.Content);
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
                Label1.Content = Number1;
            }
            else if (Number1 != 0 & Number2 == 0)
            {
                
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

                if (Sign == "+") { Number1 = Number1 + Number2; }

                else if (Sign == "-") { Number1 = Number1 - Number2; }

                else if (Sign == "*") { Number1 = Number1 * Number2; }

                else { Number1 = Number1 / Number2; }

                Label1.Content = Number1;
            }
            else
            {
                if (Sign == "+") { Number1 = Number1 + Number2; }

                else if (Sign == "-") { Number1 = Number1 - Number2; }

                else if (Sign == "*") { Number1 = Number1 * Number2; }

                else { Number1 = Number1 / Number2; }

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
                Label1.Content = Number1;
                Number2 = 0;
            }
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
            Number1 = 0;
            Number2 = 0;
            Sign = null;
        }

    }
}
