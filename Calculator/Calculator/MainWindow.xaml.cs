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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool hasDot = false;
        private String[] parts = { null, null };
        private String operation = null;
        public MainWindow() => InitializeComponent();

        private void Button_Close(object sender, RoutedEventArgs e) => this.Close();

        private void Button_Click_Numbers(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            if (textLabel.Text == "0") textLabel.Text = "";
            if (operation != null && (textLabel.Text == parts[0] || textLabel.Text == "Деление на ноль невозможно")) textLabel.Text = ""+btn.Content;
            else textLabel.Text += btn.Content;
        }

        private void Button_Click_MP(object sender, RoutedEventArgs e)
        {
            if (textLabel.Text != "0")
            {
                if (textLabel.Text[0] != '-') textLabel.Text = "-"+textLabel.Text;
                else textLabel.Text = textLabel.Text.Remove(0,1);
            }
        }

        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            if (textLabel.Text[textLabel.Text.Length-1] == ',') hasDot = false;
            textLabel.Text = textLabel.Text.Remove(textLabel.Text.Length-1, 1);
            if (textLabel.Text == "" || textLabel.Text == "-") textLabel.Text = "0";
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "0";
            hasDot = false;
            operation = null;
            parts[0] = null;
            parts[1] = null;
        }

        private void Button_Click_CE(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "0";
            hasDot = false;
        }

        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            if (!hasDot)
            {
                if (operation != null && textLabel.Text == parts[0]) textLabel.Text = "0,";
                else textLabel.Text += ",";
                hasDot = true;
            }
        }

        private void getOp()
        {
            switch (operation)
            {
                case "+": parts[0] = ""+(double.Parse(parts[0]) + double.Parse(parts[1]));
                    break;
                case "-": parts[0] = "" + (double.Parse(parts[0]) - double.Parse(parts[1]));
                    break;
                case "*": parts[0] = "" + (double.Parse(parts[0]) * double.Parse(parts[1]));
                    break;
                case "/":
                    if (parts[1] != "0") parts[0] = "" + (double.Parse(parts[0]) / double.Parse(parts[1]));
                    else parts[0] = "Деление на ноль невозможно";
                    break;
            }
            textLabel.Text = parts[0];
            parts[1] = null;
            int pr = 0;
            if (int.TryParse(parts[0], out pr)) hasDot = false;
            if (parts[0] == "Деление на ноль невозможно")
            {
                operation = null;
                parts[0] = null;
                parts[1] = null;
            }
        }

        private void doFunc(String op)
        {
            if (textLabel.Text[textLabel.Text.Length - 1] != ',' && textLabel.Text != "Деление на ноль невозможно")
            {
                if (operation != null)
                {
                    parts[1] = textLabel.Text;
                    getOp();
                    if (textLabel.Text != "Деление на ноль невозможно") operation = op;
                }
                else
                {
                    operation = op;
                    parts[0] = textLabel.Text;
                }
            }
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e) => doFunc("+");

        private void Button_Click_Minus(object sender, RoutedEventArgs e) => doFunc("-");

        private void Button_Click_Multiply(object sender, RoutedEventArgs e) => doFunc("*");

        private void Button_Click_Blow(object sender, RoutedEventArgs e) => doFunc("/");

        private void Button_Click_Result(object sender, RoutedEventArgs e) => doFunc(null);

        private void Button_Click_Percent(object sender, RoutedEventArgs e)
        {
            if (parts[0] == null) textLabel.Text = "0";
            else textLabel.Text = "" + (double.Parse(parts[0]) / 100 * double.Parse(textLabel.Text));
        }

        private void Button_Click_M1S(object sender, RoutedEventArgs e) => textLabel.Text = "" + (1/double.Parse(textLabel.Text));

        private void Button_Click_2S(object sender, RoutedEventArgs e) => textLabel.Text = "" + Math.Pow(double.Parse(textLabel.Text), 2);

        private void Button_Click_K2S(object sender, RoutedEventArgs e) => textLabel.Text = "" + Math.Sqrt(double.Parse(textLabel.Text));

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (((int)e.Key) < 34 || ((int)e.Key) > 43) e.Handled = true;
        }

        private void Window_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (textLabel.Text == "0") textLabel.Text = "";
            if (operation != null && (textLabel.Text == parts[0] || textLabel.Text == "Деление на ноль невозможно")) textLabel.Text = "" + e.Text;
            else textLabel.Text += e.Text;
        }
    }
}
