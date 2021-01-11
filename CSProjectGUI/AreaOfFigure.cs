using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectGUI
{
     public class AreaOfFigure
      {
            /// <summary>
            /// Class For Computation Of Area Of A Figure
            /// </summary>
            /// <param name="a_base"></param>
            /// <param name="height"></param>
            /// <returns></returns>
            public static double areaOfTriangle (double a_base, double height)
            {
                  return Math.Round( 0.5 * a_base * height,3);
            }

            public static double areaOfRectangle (double width, double height)
            {
                  return Math.Round(width * height,3);
            }

            public static double totalSurfaceAreaOfCone (double length, double radius, double pi = Math.PI)
            {
                  return Math.Round((pi * radius * length) + (pi * (Math.Pow(radius, 2))),3);
            }
      }
 
}
