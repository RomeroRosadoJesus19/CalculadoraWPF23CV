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

namespace Calculadora23CV
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

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                string value = (string)button.Content;

                if (IsNumber(value))
                {
                    HandleNumbers(value);   
                }
                else if (IsOperator(value)) 
                {
                    HandleOperator(value);  
                }

            }
           catch (Exception ex)
           {

                throw new Exception("Surgio un error"+ex.Message);  
            }
        }

       private bool IsNumber(string Num)
        {
            //if (double.TryParse(Num, out _))
            //{ 
            //    return true;    
            //}
            return double.TryParse(Num, out _);  

        }


        private void HandleNumbers(string value)
        {
            if (string.IsNullOrEmpty(Screen.Text))
            {
                Screen.Text = value;
            }
            else
            {
                Screen.Text += value;
            }
             
        }

        private bool IsOperator(string posibleOperator)
        {
            //if (posibleOperator == "+" || posibleOperator == "*" || posibleOperator == "*" || posibleOperator == "/" )
            //{
            //    return true;    
            //}
            //return false;

            return posibleOperator == "+" || posibleOperator == "*" || posibleOperator == "*" || posibleOperator == "/";
        }

        private void HandleOperator(string value)
        {
            if (!String.IsNullOrEmpty(Screen.Text)) 
            {
                Screen.Text += value;
            }
        }



    }
}

