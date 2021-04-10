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

namespace MyCalculatorv1
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
            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
            
                Button b = (Button)sender;
                DisplayerTxtBx.Text += b.Content.ToString();
            }

            private void Result_click(object sender, RoutedEventArgs e)
            {
                try
                {
                    result();
                }
                catch (Exception exc)
                {
                    DisplayerTxtBx.Text = "Error!";
                }
            }

            private void result()
            {
                String op;
                int iOp = 0;
                if (DisplayerTxtBx.Text.Contains("+"))
                {
                    iOp = DisplayerTxtBx.Text.IndexOf("+");
                }
                else if (DisplayerTxtBx.Text.Contains("-"))
                {
                    iOp = DisplayerTxtBx.Text.IndexOf("-");
                }
                else if (DisplayerTxtBx.Text.Contains("*"))
                {
                    iOp = DisplayerTxtBx.Text.IndexOf("*");
                }
                else if (DisplayerTxtBx.Text.Contains("/"))
                {
                    iOp = DisplayerTxtBx.Text.IndexOf("/");
                }
                else
                {
                    //error    
                }

                op = DisplayerTxtBx.Text.Substring(iOp, 1);
                double op1 = Convert.ToDouble(DisplayerTxtBx.Text.Substring(0, iOp));
                double op2 = Convert.ToDouble(DisplayerTxtBx.Text.Substring(iOp + 1, DisplayerTxtBx.Text.Length - iOp - 1));

                if (op == "+")
                {
                    DisplayerTxtBx.Text += "=" + (op1 + op2);
                }
                else if (op == "-")
                {
                    DisplayerTxtBx.Text += "=" + (op1 - op2);
                }
                else if (op == "*")
                {
                    DisplayerTxtBx.Text += "=" + (op1 * op2);
                }
                else
                {
                    DisplayerTxtBx.Text += "=" + (op1 / op2);
                }
            }

            private void Off_Click_1(object sender, RoutedEventArgs e)
            {
                Application.Current.Shutdown();
            }

            private void Del_Click(object sender, RoutedEventArgs e)
            {
                DisplayerTxtBx.Text = "";
            }

            private void R_Click(object sender, RoutedEventArgs e)
            {
                if (DisplayerTxtBx.Text.Length > 0)
                {
                    DisplayerTxtBx.Text = DisplayerTxtBx.Text.Substring(0, DisplayerTxtBx.Text.Length - 1);
                }
            }
        }
    }

