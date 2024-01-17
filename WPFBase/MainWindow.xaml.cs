using System;
using System.Data;
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
using System.Net.Http;
using System.Reflection.Emit;

namespace Calculator
{

    public partial class MainWindow : Window
    {
        double operand1 = 0;
        double operand2 = 0;
        string operatori = "";


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string text = button.Content.ToString();
            if (textBlock.Text == "0")
            {
                textBlock.Text = "";
            }
            if (double.TryParse(text, out _))
            {
                textBlock.Text += text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                operand1 = double.Parse(textBlock.Text);
                operatori = text;
                textBlock.Text = "";
            }
            else if (text == "=")
            {
                Equals_Click();
            }
            else if (text == "AC")
            {
                operand1 = 0;
                operatori = "";
                textBlock.Text = "0";
            }
        }


        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operatori = button.Content.ToString();
            operand1 = double.Parse(textBlock.Text);
            textBlock.Text = "";
        }

        private void Equals_Click()
        {
            double operand2 = double.Parse(textBlock.Text);

            switch (operatori)
            {
                case "+":
                    textBlock.Text = (operand1 + operand2).ToString();
                    break;
                case "-":
                    textBlock.Text = (operand1 - operand2).ToString();
                    break;
                case "*":
                    textBlock.Text = (operand1 * operand2).ToString();
                    break;
                case "/":
                    textBlock.Text = (operand1 / operand2).ToString();
                    break;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
            operand1 = 0;
            operand2 = 0;
            operatori = "";
        }
    }
}