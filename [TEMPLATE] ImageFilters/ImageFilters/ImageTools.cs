using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilters
{
    /* HELPING METHODS */
    class ImageTools
    {
        public static byte[] to1D(byte[,] array)
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

        public static byte[] exclude(byte[] array, int T)
        {
            byte[] newArray = new byte[array.Length - (T * 2)];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[T + i];
            }

            return newArray;
        }

        public static byte arrAverage(byte[] arr)
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

        //byte calcAverage(byte[] array) {
        //    byte avg = 0;
        //    for (int i = 0; i < array.Length; i++) {
        //        avg += array[i];
        //    }

        //    avg /= Convert.ToByte(array.Length);

        //    return avg;
        //}

        public static byte[,] initArray(byte[,] image, int MaxWinSiz)
        {
            int X_mask1 = MaxWinSiz;
            int X_mask2 = 1;
            int Y_mask1 = MaxWinSiz;
            int Y_mask2 = 1;
            byte[,] initImage = new byte[image.GetLength(0) + (MaxWinSiz) - 1, image.GetLength(1) + (MaxWinSiz) - 1];

            for (int i = 0; i < initImage.GetLength(0); i++)
            {
                Y_mask1 = MaxWinSiz;
                Y_mask2 = 1;

                for (int j = 0; j < initImage.GetLength(1); j++)
                {

                    if (i < MaxWinSiz / 2 && j >= MaxWinSiz / 2 && i < initImage.GetLength(0) - (MaxWinSiz / 2) && j < initImage.GetLength(1) - (MaxWinSiz / 2))
                    {
                        initImage[i, j] = image[X_mask1, j - (MaxWinSiz / 2)];

                    }
                    else if (i >= initImage.GetLength(0) - (MaxWinSiz / 2) && j >= MaxWinSiz / 2 && j < initImage.GetLength(1) - (MaxWinSiz / 2))
                    {
                        initImage[i, j] = image[i - (MaxWinSiz / 2) - X_mask2, j - (MaxWinSiz / 2)];

                    }



                    else if (j < MaxWinSiz / 2 && i >= MaxWinSiz / 2 && i < initImage.GetLength(0) - (MaxWinSiz / 2))
                    {
                        initImage[i, j] = image[i - (MaxWinSiz / 2), Y_mask1];
                    }
                    else if (j >= initImage.GetLength(1) - (MaxWinSiz / 2) && i >= MaxWinSiz / 2 && i < initImage.GetLength(0) - (MaxWinSiz / 2))
                    {
                        initImage[i, j] = image[i - (MaxWinSiz / 2), j - (MaxWinSiz / 2) - Y_mask2];
                    }



                    else if (i >= MaxWinSiz / 2 && j >= MaxWinSiz / 2 && i < initImage.GetLength(0) - (MaxWinSiz / 2) && j < initImage.GetLength(1) - (MaxWinSiz / 2))
                    {
                        initImage[i, j] = image[i - (MaxWinSiz / 2), j - (MaxWinSiz / 2)];
                    }
                    else
                    {
                        initImage[i, j] = 0;
                    }

                    Y_mask1--;
                    if (j >= initImage.GetLength(1) - (MaxWinSiz / 2))
                    { Y_mask2++; }
                }

                X_mask1--;
                if (i >= initImage.GetLength(0) - (MaxWinSiz / 2))
                { X_mask2++; }

            }
            return initImage;
        }
    }
}
