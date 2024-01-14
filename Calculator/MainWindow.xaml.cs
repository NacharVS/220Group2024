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
using System.Text.RegularExpressions;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string globalNumber;
        string globalNumber1;
        string globalCalculation;
        string globalSign;
        string globalresultString;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (text_label.Text == "0" || text_label.Text == null)
            {
                if (clickedButton.Content.ToString() == "+" || clickedButton.Content.ToString() == "-" || 
                    clickedButton.Content.ToString() == "*" || clickedButton.Content.ToString() == "/" || 
                    clickedButton.Content.ToString() == "=")
                {
                    text_label.Text = null;
                }
                else if (clickedButton.Content.ToString() == "C")
                {
                    text_label.Text = "0";
                }
                else
                {
                    text_label.Text = null;
                    text_label.Text = clickedButton.Content.ToString();
                    globalNumber = text_label.Text;
                }
            }
            else
            {
                text_label.Text += clickedButton.Content.ToString();               

                if (clickedButton.Content.ToString() == "+" || clickedButton.Content.ToString() == "-"
                   || clickedButton.Content.ToString() == "*" || clickedButton.Content.ToString() == "/")
                {
                    globalNumber = text_label.Text;
                    globalresultString = Regex.Replace(globalNumber, "[^0-9]", "");
                    text_label.Text = null;
                    globalSign = clickedButton.Content.ToString();
                }
                if (clickedButton.Content.ToString() == "=")
                {
                     globalNumber1 = text_label.Text;
                     text_label.Text = null;                   
                    string resultString1 = Regex.Replace(globalNumber1, "[^0-9]", "");
                    globalCalculation = $"{globalresultString} {globalSign} {resultString1}";
                    globalCalculation = new DataTable().Compute(globalCalculation, null).ToString();
                    text_label.Text = globalCalculation; 

                }
                else if (clickedButton.Content.ToString() == "C")
                {
                    text_label.Text = "0";
                }
            }
        
        }



        private void One_Click(object sender, RoutedEventArgs e)
        {
           Button_Click(sender, e);
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }
    }
}
