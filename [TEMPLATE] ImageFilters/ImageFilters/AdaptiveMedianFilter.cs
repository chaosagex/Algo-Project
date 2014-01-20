using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ImageFilters
{

    public class AdaptiveMedianFilter
    {
        #region variables
        private PictureBox pictureBox;
        private SortingType sortingType;
        private int WinMaxSiz;
        private int WinSize = 3;
        private int Zxy, Zmax, Zmin, Zmed;
        private byte A1, A2, B1, B2, NewPixelVal;
        private int x, y;
        private byte[] ImgWindow;
        private byte[,] imageMatrix;
        private byte[,] initImage;
        #endregion
       
        public AdaptiveMedianFilter(byte[,] image, int WinMxSiz)
        {
            this.WinMaxSiz = WinMxSiz;
            imageMatrix = new byte[image.GetLength(0), image.GetLength(1)];
            initImage = ImageTools.initArray(image, WinMaxSiz);
            //initImage = initArray(image, WinMaxSiz);
            //  DisplayImage(initImage, pictureBox);


        }
        #region filtering
        //---------------------------------------------------------------------------------------------------------
       


        //---------------------------------------------------------------------------------------------------------
        public void Filter(SortingType sortingType)
        {
            int x_init = WinMaxSiz / 2;
            int y_init = WinMaxSiz / 2;

            for (int X = 0; X < imageMatrix.GetLength(0); X++)
            {
                for (int Y = 0; Y < imageMatrix.GetLength(1); Y++)
                {
                    SrchTruMedian(window(x_init + X, y_init + Y, initImage, WinSize, WinMaxSiz), WinSize, initImage, x_init + X, y_init + Y, sortingType);

                    imageMatrix[X, Y] = NewPixelVal;
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
       
       
        private byte[] window(int X, int Y, byte[,] image, int Wsize, int WinMaxSiz)
        {
            ImgWindow = new byte[Wsize * Wsize];

            x = X - (Wsize / 2);
            y = Y - (Wsize / 2);
            int k = 0;
            for (int i = 0; i < Wsize; i++)
            {

               for (int j = 0; j < Wsize; j++)
                {

                    ImgWindow[k] = image[x, y];
                    y++;
                    k++;
                }
                y = Y - (Wsize / 2);
                x++;

            }

            return ImgWindow;
        }


        private void SrchTruMedian(byte[] ImgWindow, int Wsize, byte[,] image, int X, int Y, SortingType sortingType)
        {
               if (sortingType == SortingType.COUNTING_SORT)
               {
                   ImgWindow=Sort.CountingSort.sort(ImgWindow);                
               }
               else if (sortingType == SortingType.QUICK_SORT)
               {
                   int right=ImgWindow.Length-1 ;
                    Sort.quicksort.QuickSort_Recursive(ImgWindow,0,right); 
               }
               else 
               { Array.Sort(ImgWindow); }
              
           // Array.Sort(ImgWindow);
            Zxy = image[X, Y];
            Zmax = ImgWindow[(Wsize * Wsize) - 1];
            Zmin = ImgWindow[0];
            Zmed = ImgWindow[(int)((Wsize * Wsize) / 2)];
            A1 = (byte)(Zmed - Zmin);
            A2 = (byte)(Zmax - Zmed);
            if (A1 > 0 && A2 > 0)
            {
                B1 = (byte)(Zxy - Zmin);
                B2 = (byte)(Zmax - Zxy);
                if (B1 > 0 && B2 > 0)
                {
                    NewPixelVal = (byte)Zxy;
                }
                else
                {

                    NewPixelVal = (byte)Zmed;
                }
            }
            else
            {
                Wsize += 2;
                if (Wsize <= WinMaxSiz)
                {
                    SrchTruMedian(window(X, Y, image, Wsize, WinMaxSiz), Wsize, image, X, Y,sortingType);
                }
                else
                {
                    NewPixelVal = (byte)Zmed;
                }
            }

        }
#endregion

        public byte[,] getFilteredImage()
        {
            return imageMatrix;
        }

        public void DisplayImage(byte[,] imageMatrix, PictureBox picturebox)
        {
            ImageFilters.ImageOperations.DisplayImage(imageMatrix, pictureBox);
        }
        #region helpful mwthods
        public byte[] convert(byte[,] win, int size)
        {
            byte[] arr = new byte[size * size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[(i * size) + j] = win[i, j];
                }
            }
            return arr;
        }

        byte[,] initArray(byte[,] image, int MaxWinSiz)
        {
            int X_mask1 = MaxWinSiz;
            int X_mask2 = 1;
            int Y_mask1 = MaxWinSiz;
            int Y_mask2 = 1;
            for (int i = 0; i < initImage.GetLength(0); i++)
            {
                Y_mask1 = MaxWinSiz;
                Y_mask2 = 1;

                for (int j = 0; j < initImage.GetLength(1); j++)
                {


                    
                                       if (i < MaxWinSiz / 2 && j >= MaxWinSiz / 2 && i < initImage.GetLength(0) - (MaxWinSiz / 2) && j < initImage.GetLength(1) - (MaxWinSiz / 2))
                                         {
                                             initImage[i, j] = image[X_mask1,  j - (MaxWinSiz / 2)];
                         
                                         }
                                        else if (i >= initImage.GetLength(0) - (MaxWinSiz / 2) && j >= MaxWinSiz / 2  && j < initImage.GetLength(1) - (MaxWinSiz / 2))
                                        {
                                            initImage[i, j] = image[i-(MaxWinSiz / 2)-X_mask2 , j - (MaxWinSiz / 2)];
                        
                                        }

                     
                     
                                       else  if (j < MaxWinSiz / 2 && i >= MaxWinSiz / 2  && i < initImage.GetLength(0) - (MaxWinSiz / 2))
                                         {
                                             initImage[i, j] = image[i - (MaxWinSiz / 2) , Y_mask1];
                                         }
                                        else if (j >= initImage.GetLength(1) - (MaxWinSiz / 2) && i>= MaxWinSiz / 2  && i < initImage.GetLength(0) - (MaxWinSiz / 2))
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
        #endregion

    }

}