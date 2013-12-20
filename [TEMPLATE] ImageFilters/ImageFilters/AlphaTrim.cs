using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ImageFilters
{
    class AlphaTrimFilter
    {
        private byte[,] imageMatrix;
        private PictureBox pictureBox;
        private SortingType sortingType;

        public AlphaTrimFilter(byte[,] imageMatrix, PictureBox pictureBox, SortingType sortingType)
        {
            this.imageMatrix = (byte[,])imageMatrix.Clone();
            this.pictureBox  = pictureBox;
            this.sortingType = sortingType;
        }

        public void removeNoise(int windowSize, int trimValue)
        {
            if (windowSize <= 1)
                MessageBox.Show("The window size must be bigger than 1.", "Wrong Value", MessageBoxButtons.OK);
            else if (windowSize % 2 == 0)
                MessageBox.Show("The window size must be odd.", "Wrong Value", MessageBoxButtons.OK);
            else if ((windowSize * windowSize) <= trimValue * 2)
                MessageBox.Show("Too big trim value.", "Wrong Value", MessageBoxButtons.OK);
            else
                removeNoiseRun(windowSize, trimValue);
        }

        private void removeNoiseRun(int windowSize, int trimValue)
        {
            int windowStep = (windowSize - 1) / 2;
            int imageHeight = imageMatrix.GetLength(0);
            int imageWidth = imageMatrix.GetLength(1);

            byte[,] window = new byte[windowSize, windowSize];
            //Random rnd = new Random();

            for (int i = windowStep; i < imageHeight - windowStep; i++)
            {
                for (int j = windowStep; j < imageWidth - windowStep; j++)
                {
                    /* Iterations happening for every pixel in the image */
                    //ImageMatrix[i, j] = byte.Parse(rnd.Next(255).ToString());
                    for (int m = 0, n = i - windowStep; m < windowSize; m++, n++)
                    {
                        for (int k = 0, l = j - windowStep; k < windowSize; k++, l++)
                        {
                            window[m, k] = imageMatrix[n, l];        //Making a window
                        }
                    }
                    
                    byte[] newWindow = to1D(window);                 //Convert to 1D

                    if (sortingType == SortingType.BUILT_IN_SORT){   //Sort
                        Array.Sort(newWindow);
                    }
                    else if (sortingType == SortingType.KTH_ELEMENT){
                        Sort.kth_element kthSort = new Sort.kth_element(ref newWindow, trimValue);
                    }
                    else if (sortingType == SortingType.COUNTING_SORT){
                        //newWindow = Sort.countingsort.CountingSort(newWindow);
                    }
                    else
                    {
                        //Waiting...
                    }

                    newWindow = exclude(newWindow, trimValue); //Exclude by trim (T)
                    byte avg  = arrAverage(newWindow);         //Claculate average

                    //btnOpen.Text = avg.ToString();    //FOR TESTING ONLY. PERFORMANCE KILLER!

                    imageMatrix[i, j] = avg;            //Setting the damn value.
                    pictureBox.Update();                //Updating the show. NOT necessary, but showy.
                }
            }

            //Final display:
            ImageOperations.DisplayImage(imageMatrix, pictureBox);
        }



        /* HELPING METHODS */

        byte[] to1D(byte[,] array)
        {
            int arrayHeight = array.GetLength(0);
            int arrayWidth = array.GetLength(1);
            byte[] newArray = new byte[arrayWidth * arrayHeight];
            int indexCounter = 0;

            for (int i = 0; i < arrayHeight; i++)
            {
                for (int j = 0; j < arrayWidth; j++)
                {
                    newArray[indexCounter] = array[i, j];
                    indexCounter++;
                }
            }

            return newArray;
        }

        byte[] exclude(byte[] array, int T)
        {
            byte[] newArray = new byte[array.Length - (T * 2)];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[T + i];
            }

            return newArray;
        }

        //byte calcAverage(byte[] array) {
        //    byte avg = 0;
        //    for (int i = 0; i < array.Length; i++) {
        //        avg += array[i];
        //    }

        //    avg /= Convert.ToByte(array.Length);

        //    return avg;
        //}

        public byte arrAverage(byte[] arr)
        {
            int sum = 0;
            int average = 0;
            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;

            return Convert.ToByte(average);
        }
    }
}
