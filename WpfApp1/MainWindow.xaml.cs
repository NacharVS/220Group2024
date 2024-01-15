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
        public MainWindow()
        {
            InitializeComponent();
        }
        int e1 = 0;
        string action;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (tablo.Content.ToString() != "0")
            {
                tablo.Content += "1";
            }
            else
            {
                tablo.Content = "1";
            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (tablo.Content.ToString() != "0")
            {
                tablo.Content += "2";
            }
            else
            {
                tablo.Content = "2";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (tablo.Content.ToString() != "0")
            {
                tablo.Content += "3";
            }
            else
            {
                tablo.Content = "3";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (tablo.Content.ToString() != "0")
            {
                tablo.Content += "4";
            }
            else
            {
                tablo.Content = "4";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (tablo.Content.ToString() != "0")
            {
                tablo.Content += "5";
            }
            else
            {
                tablo.Content = "5";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (tablo.Content.ToString() != "0")
            {
                tablo.Content += "6";
            }
            else
            {
                tablo.Content = "6";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (tablo.Content != "0")
            {
                tablo.Content += "7";
            }
            else
            {
                tablo.Content = "7";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (tablo.Content.ToString() != "0")
            {
                tablo.Content += "8";
            }
            else
            {
                tablo.Content = "8";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (tablo.Content.ToString() != "0")
            {
                tablo.Content += "9";
            }
            else
            {
                tablo.Content = "9";
            }
        }

        private void Button_Click_ravno(object sender, RoutedEventArgs e)
        {
            if (action == "minus")
            {
                int e2 = Convert.ToInt32(tablo.Content.ToString());
                tablo.Content = e1 - e2;
            }
            if (action == "plus")
            {
                int e2 = Convert.ToInt32(tablo.Content.ToString());
                tablo.Content = e1 + e2;
            }
            if (action == "umn")
            {
                int e2 = Convert.ToInt32(tablo.Content.ToString());
                tablo.Content = e1 * e2;
            }
            if (action == "del")
            {
                int e2 = Convert.ToInt32(tablo.Content.ToString());
                tablo.Content = e1 / e2;
            }
        }
        
        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            e1 = Convert.ToInt32(tablo.Content.ToString());
            tablo.Content = "0";
            action = null;
            action = "minus";
        }

        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            e1 = Convert.ToInt32(tablo.Content.ToString());
            tablo.Content = "0";
            action = null;
            action = "plus";
        }

        private void Button_Click_umn(object sender, RoutedEventArgs e)
        {
            e1 = Convert.ToInt32(tablo.Content.ToString());
            tablo.Content = "0";
            action = null;
            action = "umn";
        }

        private void Button_Click_del(object sender, RoutedEventArgs e)
        {
            e1 = Convert.ToInt32(tablo.Content.ToString());
            tablo.Content = "0";
            action = null;
            action = "del";
        }

        private void Button_Click_sbros(object sender, RoutedEventArgs e)
        {
            tablo.Content = "0";
        }
    }
}
