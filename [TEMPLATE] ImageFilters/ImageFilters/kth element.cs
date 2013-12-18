using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
     class kth_element
     {
          private byte[] arr;
          private byte k = 0;

          public kth_element(ref byte[] arr, byte k)
          {
               // TODO: Complete member initialization
               this.arr = arr;
               this.k = k;
               update();
          }

          private void update()
          {
               int index;
               int begin=0;
               int end=arr.Length-1;
               for (int l = 0; l < k; l++)
               {
                    index = smallest(ref arr, begin, end);
                    Swap(ref arr[index], ref arr[begin]);
                    begin++;
                    index = largest(ref arr, begin, end);
                    Swap(ref arr[index], ref arr[end]);
                    end--;
               }
               byte[] temp = new byte[end+1];
               Array.Copy(arr, temp, end+1);
               arr = temp;
          }

          private int smallest(ref byte[] arr, int begin, int end)
          {
               if (begin + 1 == end)
               {
                    if (arr[begin] > arr[end])
                         return end;
                    else
                         return begin;
               }
               if (begin == end)
                    return end;
               int i = begin+1;
               int j = end;
               int pivot = begin;
               while (j > i)
               {
                    while (arr[i] <= arr[pivot])
                    {
                         if (i == end)
                              return smallest(ref arr, begin+1, j); ;
                         i++;
                    }
                    while (arr[j] > arr[pivot])
                         j--;
                    if (i < j)
                         Swap(ref arr[i], ref arr[j]);
               }
               Swap(ref arr[j], ref arr[pivot]);
               return smallest(ref arr, begin, j);
          }
          private int largest(ref byte[] arr, int begin, int end)
          {
               if (begin + 1 == end)
               {
                    if (arr[begin] < arr[end])
                         return end;
                    else
                         return begin;
               }
               if(begin==end)
                    return end;
               int i = begin+1;
               int j = end;
               int pivot = begin;
               while (j > i)
               {
                    while (arr[i] <= arr[pivot])
                    {
                         if (i == end)
                              return pivot;
                         i++;
                    }
                    while (arr[j] > arr[pivot])
                         j--;
                    if (i < j)
                         Swap(ref arr[i], ref arr[j]);
               }
               Swap(ref arr[j], ref arr[pivot]);
               return largest(ref arr,j+1,end);
          }
          static void Swap<T>(ref T lhs, ref T rhs)
          {
               T temp;
               temp = lhs;
               lhs = rhs;
               rhs = temp;
          }
     }
}
