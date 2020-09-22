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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float num1 = 0;
        float num2 = 0;
        float decimal1 = 1;
        float decimal2 = 1;
        string oper = "";
        bool dot = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        //btn num
        private void btn_num0_Click(object sender, RoutedEventArgs e)
        {
            if(oper == "")
            {  
                num1 = num1 * 10;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "0";
                if(dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "0";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num1_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 1;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "1";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 1;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "1";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num2_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 2;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "2";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 2;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "2";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num3_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 3;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "3";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 3;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "3";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num4_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 4;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "4";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 4;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "4";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num5_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 5;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "5";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 5;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "5";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num6_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 6;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "6";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 6;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "6";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num7_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 7;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "7";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 7;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "7";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num8_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 8;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "8";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 8;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "8";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_num9_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = num1 * 10 + 9;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "9";
                if (dot == true)
                {
                    decimal1 *= 10;
                }
            }
            else
            {
                num2 = num2 * 10 + 9;
                if (txt_result.Text == "0")
                {
                    txt_result.Text = "";
                }

                txt_result.Text += "9";
                if (dot == true)
                {
                    decimal2 *= 10;
                }
            }
        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            txt_result.Text += ".";
            dot = true;
        }

        //btn control
        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            if(oper == "")
            {
                num1 = 0;
                decimal1 = 1;
                dot = false;
            }
            else
            {
                num2 = 0;
                decimal2 = 1;
                dot = false;
            }

            txt_result.Text = "0";
        }

        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            decimal1 = 1;
            decimal2 = 1;
            oper = "";
            dot = false;
            txt_result.Text = "0";
            txt_input.Text = "";
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            float result;
            switch (oper)
            {  
                case "+":
                    txt_input.Text += txt_result.Text;
                    result = (num1 / decimal1) + (num2 / decimal2);
                    txt_result.Text = result.ToString();
                    break;

                case "-":
                    txt_input.Text += txt_result.Text;
                    result = (num1 / decimal1) - (num2 / decimal2);
                    txt_result.Text = result.ToString();
                    break;

                case "*":
                    txt_input.Text += txt_result.Text;
                    result = (num1 / decimal1) * (num2 / decimal2);
                    txt_result.Text = result.ToString();
                    break;

                case "/":
                    txt_input.Text += txt_result.Text;
                    result = (num1 / decimal1) / (num2 / decimal2);
                    txt_result.Text = result.ToString();
                    break;
            }

            num1 = 0;
            num2 = 0;
            decimal1 = 1;
            decimal2 = 1;
            oper = "";
            dot = false;
        }

        //btn operator
        private void btn_sum_Click(object sender, RoutedEventArgs e)
        {
            txt_input.Text = txt_result.Text;
            txt_input.Text += "+";
            txt_result.Text = "0";
            oper = "+";
            dot = false;
        }

        private void btn_subtract_Click(object sender, RoutedEventArgs e)
        {
            txt_input.Text = txt_result.Text;
            txt_input.Text += "-";
            txt_result.Text = "0";
            oper = "-";
            dot = false;
        }

        private void btn_multiply_Click(object sender, RoutedEventArgs e)
        {
            txt_input.Text = txt_result.Text;
            txt_input.Text += "*";
            txt_result.Text = "0";
            oper = "*";
            dot = false;
        }

        private void btn_devide_Click(object sender, RoutedEventArgs e)
        {
            txt_input.Text = txt_result.Text;
            txt_input.Text += "/";
            txt_result.Text = "0";
            oper = "/";
            dot = false;
        }
    }
}
