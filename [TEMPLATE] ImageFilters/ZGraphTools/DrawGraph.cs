using System;
using System.Collections.Generic;
using System.Text;
using ZGraphTools;

namespace ZGraphTools
{
     class DrawGraph
     {

          public void draw(int wMax, Graph g)
          {
           ZGraphForm z;
           int size = 3;
           double[] x;
           double[] y;
           int index = 0;
           int before;
           int after;
               if (g == Graph.ADAPTIVE_MEDIAN)
                    z = new ZGraphForm("Adaptive Median", "Window Size", "Time");
               else
                    z = new ZGraphForm("Alpha Trim", "Window Size", "Time");
               x = new double[wMax];
               y = new double[wMax];
               while (size < wMax)
               {
                    
                    if (g == Graph.ADAPTIVE_MEDIAN)
                    {
                         before = System.Environment.TickCount;
                         //operation code 
                    }
                    else
                    {
                         before = System.Environment.TickCount;
                         //operation code  
                    }
                    after = System.Environment.TickCount;
                    y[index] = after - before;
                    x[index] = size;
                    size += 2;
                    index++;
               }
               z.add_curve("Name goes here", x, y, System.Drawing.Color.Black);
          }
     }
}
