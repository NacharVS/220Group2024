using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Linq;

namespace calcucaltor
{
    public partial class MainWindow : Window
    {
        private double operand1 = 0;
        private string operato = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string text = button.Content.ToString();
            if(lable.Text == "0")
            {
                lable.Text = "";
            }
            if (double.TryParse(text, out _))
            {
                lable.Text += text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                operand1 = double.Parse(lable.Text);
                operato = text;
                lable.Text = "";
            }
            else if (text == "=")
            {
                performOperation();
            }
            else if (text == "AC")
            {
                operand1 = 0;
                operato = "";
                lable.Text = "0";
            }
        }

        private void performOperation()
        {
            double operand2 = double.Parse(lable.Text);
            double result;

            switch (operato)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        lable.Text = "Error: Division by zero";
                        return;
                    }
                    result = operand1 / operand2;
                    break;
                default:
                    result = 0;
                    break;
                }

                lable.Text = result.ToString();
            }
        }
    }
