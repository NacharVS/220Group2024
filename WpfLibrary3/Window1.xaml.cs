using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfLibrary3
{
    public partial class Window1 : Window
    {
        string leftValue = "";
        string rightValue = "";
        string operation = "";

        public Window1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (operation == "")
            {
                leftValue += button.Content.ToString();
                displayBox.Text = leftValue;
            }
            else
            {
                rightValue += button.Content.ToString();
                displayBox.Text = rightValue;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Content.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            leftValue = "";
            rightValue = "";
            operation = "";
            displayBox.Text = "";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(leftValue);
            double num2 = double.Parse(rightValue);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        displayBox.Text = "Error";
                    }
                    break;
            }

            displayBox.Text = result.ToString();
            leftValue = result.ToString();
            rightValue = "";
            operation = "";
        }
    }
}