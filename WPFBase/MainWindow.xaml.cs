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

namespace Calculator
{

    public partial class MainWindow : Window
    {
        double operand1 = 0;
        double operand2 = 0;
        string operatori = "";


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string content = button.Content.ToString();

            if (content == ".")
            {
                if (!textBlock.Text.Contains("."))
                {
                    textBlock.Text += content;
                }
            }
            else
            {
                textBlock.Text += content;
            }
        }


        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operatori = button.Content.ToString();
            operand1 = double.Parse(textBlock.Text);
            textBlock.Text = "";
        }
        //private void AppendNumber(string number)
        //{
        //    if (textBlock = "+"  "-" "*"  "/")
        //    {
        //        textBlock.Text = number;
        //    }
        //    else
        //    {
        //        textBlock.Text += number;
        //    }
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    string str = (string)((Button)e.OriginalSource).Content;

        //    if (str == "AC")
        //    {
        //        textBlock.Text = "";
        //        operatori = ""; // Сбрасываем исходное число
        //    }
        //    else if (str == "=")
        //    {
        //        string value = new DataTable().Compute(operatori, null).ToString(); // Вычисляем значение, используя предыдущее значение и текущее
        //        textBlock.Text = value;
        //        operatori = value; // Присваиваем number вычисленное значение
        //    }
        //    else if (str == "+"  str == "/"  str == "*"  str == "-") // Используйте || для проверки нескольких условий
        //    {
        //        textBlock.Text = str;
        //    }
        //    else
        //    {
        //        textBlock.Text = str;
        //        operatori += str;
        //    }

        //}

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            operand2 = double.Parse(textBlock.Text);

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