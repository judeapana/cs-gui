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
      /// Interaction logic for CatalanForm.xaml
      /// </summary>
      public partial class CatalanForm : Window
      {
            public CatalanForm ( )
            {
                  InitializeComponent();
            }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
                  bool status;
                  double number;
                  double result;
                  status = Double.TryParse(c_number_txt.Text, out number);
                  if (!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  result = CatalanFactorial.catalan(number);
                  MessageBox.Show($"The Catalan  Of The Number {number} is {result}");
            }

        private void Button_Click_1 (object sender, RoutedEventArgs e)
        {
                  this.Close();
        }
    }
}
