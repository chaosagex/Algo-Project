using System;
using System.Collections.Generic;
using System.Text;
using ZGraphTools;
using ImageFilters;

namespace ZGraphTools
{
    class DrawGraph
    {
        public static void draw(int wMax, Graph g)
        {
            byte[,] dummyImage = ImageOperations.OpenImage("..\\..\\..\\..\\More Images\\tiger.png");  //Using the "tiger" image as a dummy image to use in filtering.
            //Call: "(int)numMaxWindow_Graph.Value" as wMax value when you call this method (draw).

            ZGraphForm z;
            int windowSize = 3;
            double[] x;
            double[] y;
            double[] y2;
            int index = 0;
            int before;
            int after;
                
            if (g == Graph.ADAPTIVE_MEDIAN)
                z = new ZGraphForm("Adaptive Median", "Window Size", "Time");
            else
                z = new ZGraphForm("Alpha Trim", "Window Size", "Time");
            int size = (wMax-3) / 2;
            x = new double[size];
            y = new double[size];
            y2 = new double[size];
             
            while (windowSize < wMax)
            {
                if (g == Graph.ADAPTIVE_MEDIAN)
                {
                    before = System.Environment.TickCount;
                    //operation code  
                }
                else
                {
                    /*OPERATION*/
                    AlphaTrimFilter alphaTrim = new AlphaTrimFilter(dummyImage);    //Using a dummy/empty image here instead of 'ImageMatrix' (the real image object).
 
                    //Using KTH ELEMENT:
                    before = System.Environment.TickCount;
                    alphaTrim.removeNoise(windowSize, 3, SortingType.KTH_ELEMENT);  /*The 3 here is the trim value, constant.*/
                    after = System.Environment.TickCount;
                    y[index] = after - before;

                    //Using COUNTING SORT:
                    before = System.Environment.TickCount;
                    alphaTrim.removeNoise(windowSize, 3, SortingType.COUNTING_SORT);
                    after = System.Environment.TickCount;
                    y2[index] = after - before;
                    
                }
                x[index] = windowSize;
                windowSize += 2;
                index++;
            }
            if (g == Graph.ADAPTIVE_MEDIAN)
            {
                 z.add_curve("Name goes here", x, y, System.Drawing.Color.Black);
                 z.add_curve("Name goes here", x, y2, System.Drawing.Color.Crimson);
            }
            else
            {
                 z.add_curve("Kth Element", x, y, System.Drawing.Color.Black);
                 z.add_curve("Counting Sort", x, y2, System.Drawing.Color.Crimson);
            }
            z.Show();
        }
    }
}
