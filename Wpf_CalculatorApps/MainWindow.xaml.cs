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

namespace Wpf_CalculatorApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_1(object sender, RoutedEventArgs e)
        {
          textBox.Text += "1";
        }

        private void button_2(object sender, RoutedEventArgs e)
        {
           textBox.Text += "2";
        }

        private void button_3(object sender, RoutedEventArgs e)
        {
            textBox.Text += "3";
        }

        private void button_4(object sender, RoutedEventArgs e)
        {
            textBox.Text += "4";
        }

        private void button_5(object sender, RoutedEventArgs e)
        {
            textBox.Text += "5";
        }

        private void button_6(object sender, RoutedEventArgs e)
        {
            textBox.Text += "6";
        }

        private void button_7(object sender, RoutedEventArgs e)
        {
            textBox.Text += "7";
        }

        private void button_8(object sender, RoutedEventArgs e)
        {
            textBox.Text += "8";
        }

        private void button_9(object sender, RoutedEventArgs e)
        {
            textBox.Text += "9";
        }

        private void button_0(object sender, RoutedEventArgs e)
        {
            textBox.Text += "0";
        }

        private void button_del(object sender, RoutedEventArgs e)
        {
            if(textBox.Text != null)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void button_reset(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void button_exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void operator_bagi(object sender, RoutedEventArgs e)
        {
            textBox.Text += "/";
        }

        private void operator_kali(object sender, RoutedEventArgs e)
        {
            textBox.Text += "*";
        }

        private void operator_kurang(object sender, RoutedEventArgs e)
        {
            textBox.Text += "-";
        }

        private void hasil(object sender, RoutedEventArgs e)
        {
            try
            {
                Result();
            }
            catch(Exception)
            {
                textBox.Text = "Error";
            }
        }

        private void operator_tambah(object sender, RoutedEventArgs e)
        {
            textBox.Text += "+";
        }

        public void Result ()
        {
            int operand = 0;

            if (textBox.Text.Contains("+"))
            {
                operand = textBox.Text.IndexOf("+");
            }
            else if (textBox.Text.Contains("*"))
            {
                operand = textBox.Text.IndexOf("*");
            }
            else if (textBox.Text.Contains("/"))
            {
                operand = textBox.Text.IndexOf("/");
            }
            else if (textBox.Text.Contains("-"))
            {
                operand = textBox.Text.IndexOf("-");
            }

            else
            {

            }
            
            double bil_1 = double.Parse(textBox.Text.Substring(0, operand));
            double bil_2 = double.Parse(textBox.Text.Substring(operand + 1, textBox.Text.Length - operand - 1));

            if (textBox.Text.Contains("+"))
            {
                textBox.Text = "" + (bil_1+bil_2);
            }
            else if(textBox.Text.Contains("*"))
            {
                textBox.Text = "" + (bil_1 * bil_2);
            }
            else if(textBox.Text.Contains("/"))
            {
                textBox.Text = "" + (bil_1 / bil_2);
            }
            else if (textBox.Text.Contains("-"))
            {
                textBox.Text = "" + (bil_1 - bil_2);
            }
            else
            { }
        }
    }
}
