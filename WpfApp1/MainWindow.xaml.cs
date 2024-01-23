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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Buffer;
        string Action;
        public MainWindow()
        {
           InitializeComponent();

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if(lab.Content.ToString() == "0")
            {
               lab.Content = "1";
            }
            else 
                lab.Content += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "2";
            }
            else
                lab.Content += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "3";
            }
            else
                lab.Content += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "4";
            }
            else
                lab.Content += "4";

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "5";
            }
            else
                lab.Content += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "6";
            }
            else
                lab.Content += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "7";
            }
            else
                lab.Content += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "8";
            }
            else
                lab.Content += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "9";
            }
            else
                lab.Content += "9";
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (lab.Content.ToString() == "0")
            {
                lab.Content = "0";
            }
            else
                lab.Content += "0";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Buffer = Convert.ToInt32(lab.Content);
            Action = "Plus";
            lab.Content = 0;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
           if(Action == "Plus")
            {
               lab.Content = Buffer + Convert.ToInt32(lab.Content);
                Action = null;
                Buffer = 0;
            }

            if (Action == "Minus")
            {
                lab.Content = Buffer - Convert.ToInt32(lab.Content);
                Action = null;
                Buffer = 0;
            }

            if (Action == "Multiplication")
            {
                lab.Content = Buffer * Convert.ToInt32(lab.Content);
                Action = null;
                Buffer = 0;
            }

            if (Action == "division")
            {
                lab.Content = Buffer / Convert.ToInt32(lab.Content);
                Action = null;
            
            }

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Buffer = Convert.ToInt32(lab.Content);
            Action = "Minus";
            lab.Content = 0;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Buffer = Convert.ToInt32(lab.Content);
            Action = "Multiplication";
            lab.Content = "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Buffer = Convert.ToInt32(lab.Content);
            Action = "division";
            lab.Content = "0";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Buffer = 0;
            lab.Content = "0";
        }
    }
}
