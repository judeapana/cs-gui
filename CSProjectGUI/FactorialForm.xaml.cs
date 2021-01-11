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
using System.Windows.Shapes;

namespace CSProjectGUI
{
      /// <summary>
      /// Interaction logic for FactorialForm.xaml
      /// </summary>
      public partial class FactorialForm : Window
      {
            public FactorialForm ( )
            {
                  InitializeComponent();
            }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
                  bool status;
                  double number;
                  double result;
                  status = Double.TryParse(f_number_txt.Text, out number);
                  if (!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  result = CatalanFactorial.factorial(number);
                  MessageBox.Show($"The Factorial Of The Number {number} is {result}");
        }

        private void Button_Click_1 (object sender, RoutedEventArgs e)
        {
                  this.Close();

          }
      }
}
