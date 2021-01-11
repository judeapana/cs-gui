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

namespace CSProjectGUI
{
      /// <summary>
      /// Interaction logic for MainWindow.xaml
      /// </summary>
      public partial class MainWindow : Window
      {
            public MainWindow ( )
            {
                  InitializeComponent();
            }

            private void Button_Triangle_Window (object sender, RoutedEventArgs e)
            {
                  AreaOfTriangleForm areaOfTriangleForm = new AreaOfTriangleForm();
                  areaOfTriangleForm.Show();
            }

            private void Button_Rectangle_Window (object sender, RoutedEventArgs e)
            {
                  AreaOfRectangleForm areaOfRectangleForm = new AreaOfRectangleForm();
                  areaOfRectangleForm.Show();
            }

            private void Button_Surface_Window (object sender, RoutedEventArgs e)
            {
                  TotalSurfaceAreaForm totalSurfaceAreaForm = new TotalSurfaceAreaForm();
                  totalSurfaceAreaForm.Show();
            }

             private void Button_Factorial_Window (object sender, RoutedEventArgs e)
            {
                  FactorialForm factorialForm = new FactorialForm();
                  factorialForm.Show();
            } 
            private void Button_Catalan_Window (object sender, RoutedEventArgs e)
            {
                  CatalanForm catalanForm = new CatalanForm();
                  catalanForm.Show();
            }
           
      }
}
