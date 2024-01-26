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


namespace Calculator
{
    public partial class MainWindow : Window
    {
        double operand1 = 0;
        double operand2 = 0;
        string operatori = "";
        bool newOperand = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string text = button.Content.ToString();
            if (text == "0" || text == "1" || text == "2" || text == "3" || text == "4" || text == "5" || text == "6" || text == "7" || text == "8" || text == "9")
            {
                if (newOperand)
                {
                    textBlock.Text = "";
                    newOperand = false;
                }
                textBlock.Text += text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                if (operatori == "" && double.TryParse(textBlock.Text, out _))
                {
                    operand1 = double.Parse(textBlock.Text);
                    operatori = text;
                    textBlock.Text = "";
                    newOperand = true;
                }
                else if (operatori != "" && double.TryParse(textBlock.Text, out _))
                {
                    operand2 = double.Parse(textBlock.Text);
                    Equals_Click();
                    operatori = text;
                    textBlock.Text = "";
                }
            }
            else if (text == "=")
            {
                if (operatori != "" && double.TryParse(textBlock.Text, out _))
                {
                    operand2 = double.Parse(textBlock.Text);
                    Equals_Click();
                    operatori = "";
                    newOperand = true;
                }
            }
            else if (text == "AC")
            {
                operand1 = 0;
                operatori = "";
                textBlock.Text = "0";
                newOperand = true;
            }
        }

        private void Equals_Click()
        {
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
            operand1 = double.Parse(textBlock.Text);
        }
    }
}
