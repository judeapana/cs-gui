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
      /// Interaction logic for AreaOfTriangleForm.xaml
      /// </summary>
      public partial class AreaOfTriangleForm : Window
      {
            public AreaOfTriangleForm ( )
            {
                  InitializeComponent();
                  
            }

            private void Button_Click (object sender, RoutedEventArgs e)
            {
                  this.Close();
            }

            private void Button_Click_1 (object sender, RoutedEventArgs e)
            {
                  double height;
                  double result;
                  double base_t;
                  bool status;
                  status = Double.TryParse(base_of_triangle.Text, out base_t);
                  if (!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  status = Double.TryParse(height_of_triangle.Text, out height);
                  if(!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  result = AreaOfFigure.areaOfTriangle(base_t, height);
                  MessageBox.Show($" The Area Of The Triangle Is {result}");
            }
      }
}
