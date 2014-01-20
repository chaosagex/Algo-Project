using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ImageFilters
{
    public class AlphaTrimFilter
    {
        private byte[,] imageMatrix;

        public AlphaTrimFilter(byte[,] imageMatrix)
        {
            this.imageMatrix = (byte[,])imageMatrix.Clone();
        }

        public byte[,] removeNoise(int windowSize, int trimValue, SortingType sortingType)
        {
            byte[,] newImage = null;

            if (windowSize <= 1)
                MessageBox.Show("The window size must be bigger than 1.", "Wrong Value", MessageBoxButtons.OK);
            else if (windowSize % 2 == 0)
                MessageBox.Show("The window size must be odd.", "Wrong Value", MessageBoxButtons.OK);
            else if ((windowSize * windowSize) <= trimValue * 2)
                MessageBox.Show("Too big trim value.", "Wrong Value", MessageBoxButtons.OK);
            else
                newImage = removeNoiseRun(windowSize, trimValue, sortingType);

            return newImage;
        }

        private byte[,] removeNoiseRun(int windowSize, int trimValue, SortingType sortingType)
        {
            int windowStep = (windowSize - 1) / 2;
            int imageHeight = imageMatrix.GetLength(0);
            int imageWidth = imageMatrix.GetLength(1);

            byte[,] window = new byte[windowSize, windowSize];

            for (int i = windowStep; i < imageHeight - windowStep; i++)
            {
                for (int j = windowStep; j < imageWidth - windowStep; j++)
                {
                    /* Iterations happening for every pixel in the image */
                    for (int m = 0, n = i - windowStep; m < windowSize; m++, n++)
                    {
                        for (int k = 0, l = j - windowStep; k < windowSize; k++, l++)
                        {
                            window[m, k] = imageMatrix[n, l];        //Making a window
                        }
                    }

                    byte[] newWindow = ImageTools.to1D(window);      //Convert to 1D

                    if (sortingType == SortingType.BUILT_IN_SORT){   //Sort
                        Array.Sort(newWindow);
                    }
                    else if (sortingType == SortingType.KTH_ELEMENT){
                        newWindow = Sort.KthElement.sort(ref newWindow, trimValue);
                    }
                    else if (sortingType == SortingType.COUNTING_SORT){
                        newWindow = Sort.CountingSort.sort(newWindow);
                    }

                    newWindow = ImageTools.exclude(newWindow, trimValue); //Exclude by trim (T)
                    byte avg  = ImageTools.arrAverage(newWindow);         //Claculate average

                    //btnOpen.Text = avg.ToString();    //FOR TESTING ONLY. PERFORMANCE KILLER!

                    imageMatrix[i, j] = avg;            //Setting the damn value.
                    //pictureBox.Update();              //Updating the show. NOT necessary, but showy.
                }
            }

            return imageMatrix;
        }
    }
}
