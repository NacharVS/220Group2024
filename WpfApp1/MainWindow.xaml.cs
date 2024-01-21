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
        int buff;
        int buff2;
        string act;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "1";
            }
            else
            {
                Lb.Content += "1";
            }

        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "2";
            }
            else
            {
                Lb.Content += "2";
            }

        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "3";
            }
            else
            {
                Lb.Content += "3";
            }

        }

        private void btDel_Click(object sender, RoutedEventArgs e)
        {
            buff = Convert.ToInt32(Lb.Content);
            act = "/";
            Lb.Content = "";

        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "4";
            }
            else
            {
                Lb.Content += "4";
            }

        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "5";
            }
            else
            {
                Lb.Content += "5";
            }

        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "6";
            }
            else
            {
                Lb.Content += "6";
            }

        }

        private void btUmn_Click(object sender, RoutedEventArgs e)
        {
            buff = Convert.ToInt32(Lb.Content);
            act = "*";
            Lb.Content = "";

        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "7";
            }
            else
            {
                Lb.Content += "7";
            }

        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "8";
            }
            else
            {
                Lb.Content += "8";
            }

        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "9";
            }
            else
            {
                Lb.Content += "9";
            }

        }

        private void btPlus_Click(object sender, RoutedEventArgs e)
        {
            buff = Convert.ToInt32(Lb.Content);
            act = "+";
            Lb.Content = "";


        }

        private void btRav_Click(object sender, RoutedEventArgs e)
        {
            switch(act)

            {   
                case "+":
                    Lb.Content = Convert.ToInt32(Lb.Content) + buff;
                    act = null;
                    buff = 0;                
                    break;
                case "-":
                    Lb.Content = buff - Convert.ToInt32(Lb.Content);
                    act = null;
                    buff = 0;
                    break;
                case "*":
                    Lb.Content = buff * Convert.ToInt32(Lb.Content);
                    act = null;
                    buff = 0;
                    break;
                case "/":
                    Lb.Content = buff / Convert.ToInt32(Lb.Content);
                    act = null;
                    buff = 0;
                    break;


            }
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            if (Lb.Content.ToString() == "0")
            {
                Lb.Content = "0";
            }
            else
            {
                Lb.Content += "0";
            }

        }

        private void btAC_Click(object sender, RoutedEventArgs e)
        {
            Lb.Content = "0";
        }

        private void btMinus_Click(object sender, RoutedEventArgs e)
        {
            buff = Convert.ToInt32(Lb.Content);
            act = "-";
            Lb.Content = "";


        }
    }
}
