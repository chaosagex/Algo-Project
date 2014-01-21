using System;
using System.Collections.Generic;
using System.Text;

namespace ToolBox
{
     class Tools
     {
          public static void Swap<T>(ref T lhs, ref T rhs)
          {
               T temp;
               temp = lhs;
               lhs = rhs;
               rhs = temp;
          }
     }
}
