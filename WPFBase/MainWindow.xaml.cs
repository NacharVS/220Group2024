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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string number;
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in MainRoot.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        private string previousValue = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
            {
                textBlock.Text = "";
                number = ""; // Сбрасываем исходное число
            }
            else if (str == "=")
            {
                string value = new DataTable().Compute(number, null).ToString(); // Вычисляем значение, используя предыдущее значение и текущее
                textBlock.Text = value;
                number = value; // Присваиваем number вычисленное значение
            }
            else if (str == "+" || str == "/" || str == "*" || str == "-") // Используйте || для проверки нескольких условий
            {
                textBlock.Text = str;
            }
            else
            {
                textBlock.Text = str;
                number += str;
            }
   
    }   }
}
