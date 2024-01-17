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

namespace Calculator1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content += "1";
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            lbl.Content += "2";
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            lbl.Content += "3";
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            lbl.Content += "4";
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            lbl.Content += "5";
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
                lbl.Content += "6";

        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            lbl.Content += "7";
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            lbl.Content += "8";
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            lbl.Content += "9";
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            lbl.Content += "9";
        }

        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            lbl.Content += "0";
        }

        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            lbl.Content = "";
        }

        private bool isFirstNumber = true;
        private int firstNumberPlus = 0;
        private bool isPlus;
        private bool isMinus;
        private bool isBlow;
        private bool isMultiply;
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Convert.ToString(lbl.Content), out firstNumberPlus))
            {
                lbl.Content = "";
                isFirstNumber = false;
                isPlus = true;
            }
        }
        private bool isFirstNumberMultiply = true;
        private int firstNumberMultiply = 0;
        private void Button_Click17(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Convert.ToString(lbl.Content), out firstNumberMultiply))
            {
                lbl.Content = "";
                isFirstNumberMultiply = false;
                isMultiply = true;
            }
        }
        private bool isFirstNumberMinus = true;
        private int firstNumberMinus = 0;

        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Convert.ToString(lbl.Content), out firstNumberMinus))
            {
                lbl.Content = "";
                isFirstNumberMinus = false;
                isMinus = true;
            }
        }
        private bool isFirstNumberBlow = true;
        private int firstNumberBlow = 0;

        private void Button_Click16(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Convert.ToString(lbl.Content), out firstNumberBlow))
            {
                lbl.Content = "";
                isFirstNumberBlow = false;
                isBlow = true;
            }

        }

        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            if (isPlus)
            {
                if (!isFirstNumber && int.TryParse(Convert.ToString(lbl.Content), out int secondNumber))
                {
                    int result = firstNumberPlus + secondNumber;
                    lbl.Content = result.ToString();
                    isFirstNumber = true;
                    isPlus = false;
                }
            }
            else if (isMinus)
            {
                if (!isFirstNumberMinus && int.TryParse(Convert.ToString(lbl.Content), out int secondNumber))
                {
                    int result = firstNumberMinus - secondNumber;
                    lbl.Content = result.ToString();
                    isFirstNumberMinus = true;
                    isMinus = false;
                }
            }
            else if (isBlow)
            {
                if (!isFirstNumberBlow && double.TryParse(Convert.ToString(lbl.Content), out double secondNumber))
                {
                    double result = firstNumberBlow / secondNumber;
                    lbl.Content = result.ToString();
                    isFirstNumberBlow = true;
                    isBlow = false;
                }
            }
            else if(isMultiply)
            {
                if (!isFirstNumberMultiply && int.TryParse(Convert.ToString(lbl.Content), out int secondNumber))
                {
                    int result = firstNumberMultiply * secondNumber;
                    lbl.Content = result.ToString();
                    isFirstNumberMultiply = true;
                    isMultiply = false;
                }
            }
            
        }
    }
}
