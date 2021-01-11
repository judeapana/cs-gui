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
      /// Interaction logic for AreaOfRectangleForm.xaml
      /// </summary>
      public partial class AreaOfRectangleForm : Window
      {
            public AreaOfRectangleForm ( )
            {
                  InitializeComponent();
            }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
                  this.Close();
         }

            private void Button_Click_1 (object sender, RoutedEventArgs e)
        {
                  double width, height, results;
                  bool status;
                  status = Double.TryParse(width_txt.Text, out width);
                  if (!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  status = Double.TryParse(height_txt.Text, out height);
                  if (!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  results = AreaOfFigure.areaOfRectangle(width, height);
                  MessageBox.Show($"The Area Of The Rectangle Is {results}");
            }
    }
}
