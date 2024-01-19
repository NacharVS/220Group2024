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

namespace StartLessonsWPF
{

        public partial class MainWindow : Window
        {
            //public MainWindow()
            //{
            //    InitializeComponent();
            //    foreach (UIElement el in MainRoot.Children)
            //    {
            //        if (el is Button)
            //        {
            //            ((Button)el).Click += Button_Click;
            //        }
            //    }


            //}

            //private void Button_Click(object sender, RoutedEventArgs e)
            //{
            //    string str = (string)((Button)e.OriginalSource).Content;
            //    textLabel.Text += str;
            //}
            private void hasZero()
        {
            if (textLabel.Text == "0") {
                textLabel.Text = "";
            }
        }
            private void Button_Click1(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "1";
        }

            private void Button_Click2(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "2";
            }

            private void Button_Click3(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "3";
            }

            private void Button_Click4(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "4";
            }

            private void Button_Click5(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "5";
            }

            private void Button_Click6(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "6";

            }

            private void Button_Click7(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "7";
            }

            private void Button_Click8(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "8";
            }

            private void Button_Click9(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "9";
            }

            private void Button_Click0(object sender, RoutedEventArgs e)
            {
            hasZero();
            textLabel.Text += "0";
            }

            private void Button_ClickClean(object sender, RoutedEventArgs e)
            {
                textLabel.Text = "0";
            }

            private bool isFirstNumber = true;
            private int firstNumberPlus = 0;
            private bool isPlus;
            private bool isMinus;
            private bool isBlow;

            private void Button_ClickPlus(object sender, RoutedEventArgs e)
            {
            hasZero();
            if (int.TryParse(textLabel.Text, out firstNumberPlus))
                {
                    textLabel.Text = "";
                    isFirstNumber = false;
                    isPlus = true;
                }
            }

            private bool isFirstNumberMunis = true;
            private int firstNumberMinus = 0;

            private void Button_ClickMinus(object sender, RoutedEventArgs e)
            {
            hasZero();
            if (int.TryParse(textLabel.Text, out firstNumberMinus))
                {
                    textLabel.Text = "";
                    isFirstNumberMunis = false;
                    isMinus = true;
                }
            }
            private bool isFirstNumberBlow = true;
            private int firstNumberBlow = 0;

            private void Button_ClickBlow(object sender, RoutedEventArgs e)
            {
            hasZero();
            if (int.TryParse(textLabel.Text, out firstNumberBlow))
                {
                    textLabel.Text = "*";
                    isFirstNumberBlow = false;
                    isBlow = true;
                }

            }
            private void Button_ClickEnter(object sender, RoutedEventArgs e)
            {
                if (isPlus)
                {
                    if (!isFirstNumber && int.TryParse(textLabel.Text, out int secondNumber))
                    {
                        int result = firstNumberPlus + secondNumber;
                        textLabel.Text = result.ToString();
                        isFirstNumber = true;
                        isPlus = false;
                    }
                }
                else if (isMinus)
                {
                    if (!isFirstNumberMunis && int.TryParse(textLabel.Text, out int secondNumber))
                    {
                        int result = firstNumberMinus - secondNumber;
                        textLabel.Text = result.ToString();
                        isFirstNumberMunis = true;
                        isMinus = false;
                    }
                }
                else if (double.TryParse(textLabel.Text, out double secondNumber))
                {
                    double result = firstNumberBlow / secondNumber;
                    textLabel.Text = result.ToString();
                    isFirstNumberBlow = true;
                    isBlow = false;

                }
            }

        private void Button_ClickDote(object sender, RoutedEventArgs e)
        {
            textLabel.Text += ".";
        }
    }
}
