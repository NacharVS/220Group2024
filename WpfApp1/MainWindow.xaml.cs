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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (lab.Content == "0")
            {
                lab.Content = (string)btn.Content;
            }
            else
            lab.Content += (string)btn.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            lab.Content += (string)btn.Content;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            lab.Content += (string)btn.Content;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lab.Content = "4";

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lab.Content = "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            lab.Content = "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            lab.Content = "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            lab.Content = "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            lab.Content = "9";
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            lab.Content = "0";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }
    }
}
