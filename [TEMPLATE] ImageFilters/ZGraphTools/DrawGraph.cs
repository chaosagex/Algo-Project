using System;
using System.Collections.Generic;
using System.Text;
using ZGraphTools;
using ImageFilters;

namespace ZGraphTools
{
    class DrawGraph
    {
        public void draw(int wMax, Graph g)
        {
            byte[,] dummyImage = new byte[50, 50];  //A dummy image of size 50×50px to use in filtering.

            ZGraphForm z;
            int windowSize = 3;
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
                
            while (windowSize < wMax)
            {
                if (g == Graph.ADAPTIVE_MEDIAN)
                {
                    before = System.Environment.TickCount;
                    //operation code  
                }
                else
                {
                    before = System.Environment.TickCount;

                    /*OPERATION*/
                    AlphaTrimFilter alphaTrim = new AlphaTrimFilter(dummyImage);    //Using a dummy/empty image here instead of 'ImageMatrix' (the real image object).

                    //Using KTH ELEMENT:
                    alphaTrim.removeNoise(windowSize, 3, SortingType.KTH_ELEMENT);  /*The 3 here is the trim value, constant.*/

                    //Using COUNTING SORT:
                    alphaTrim.removeNoise(windowSize, 3, SortingType.COUNTING_SORT);
                }
                    
                after = System.Environment.TickCount;
                y[index] = after - before;
                x[index] = windowSize;
                windowSize += 2;
                index++;
            }
            z.add_curve("Name goes here", x, y, System.Drawing.Color.Black);
        }
    }
}
