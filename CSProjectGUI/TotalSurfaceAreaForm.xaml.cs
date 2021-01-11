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
      /// Interaction logic for TotalSurfaceAreaForm.xaml
      /// </summary>
      public partial class TotalSurfaceAreaForm : Window
      {
            public TotalSurfaceAreaForm ( )
            {
                  InitializeComponent();
                  pi_txt.Text = Math.PI.ToString();
            }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
                  this.Close();
        }

           
        private void Button_Click_1 (object sender, RoutedEventArgs e)
        {
                  double pi, length, radius,results;
                  bool status;
                  status = Double.TryParse(pi_txt.Text, out pi);
                  if (!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  status = Double.TryParse(length_txt.Text, out length);
                  if (!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  status = Double.TryParse(radius_txt.Text, out radius);
                  if (!status)
                  {
                        MessageBox.Show("Please enter a valid value", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                  }
                  results = AreaOfFigure.totalSurfaceAreaOfCone(length, radius, pi);
                  MessageBox.Show($"Total Surface Area Of  The Cone Is {results}");
            }
    }
}
