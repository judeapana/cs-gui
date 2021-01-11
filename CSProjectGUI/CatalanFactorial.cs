using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectGUI
{
     public class CatalanFactorial
      {
            /// <summary>
            /// A Class For Computation OF Factorial And Catalan Of A Number
            /// </summary>
            /// <param name="number"></param>
            /// <returns></returns>
            public static double factorial (double number)
            {
                  if (number <= 1)
                        return 1;
                  else
                        return number * factorial(number - 1);
            }

            public static double catalan (double number)
            {
                  return CatalanFactorial.factorial(2 * number) / (CatalanFactorial.factorial(number + 1)) * CatalanFactorial.factorial(number);
            }
      }

}
