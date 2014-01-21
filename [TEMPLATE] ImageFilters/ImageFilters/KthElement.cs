using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
          //O(Kn^2)
          //Theta(Knlogn)
{
     class KthElement
     {
          //O(K)
          public static byte[] sort(ref byte[] arr, int k)
          {
               int index;
               int begin = 0;
               int end = arr.Length - 1;
               
               for (int l = 0; l < k; l++)
               {
                    index = smallest(ref arr, begin, end);
                    ToolBox.Tools.Swap(ref arr[index], ref arr[begin]);
                    begin++;
                    index = largest(ref arr, begin, end);
                    ToolBox.Tools.Swap(ref arr[index], ref arr[end]);
                    end--;
               }
               return arr;
          }
          //O(n^2)
          //Theta(nlogn)
          private static int smallest(ref byte[] arr, int begin, int end)
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
               int i = begin + 1;
               int j = end;
               int pivot = begin;
               while (j > i)
               {
                    while (arr[i] <= arr[pivot])
                    {
                         if (i == end)
                              return smallest(ref arr, begin + 1, j);
                         else
                              i++;
                    }
                    while (arr[j] > arr[pivot])
                         j--;
                    if (i < j)
                         ToolBox.Tools.Swap(ref arr[i], ref arr[j]);
               }
               ToolBox.Tools.Swap(ref arr[j], ref arr[pivot]);
               return smallest(ref arr, begin, j);
          }
          //O(n^2)
          //Theta(nlogn)
          private static int largest(ref byte[] arr, int begin, int end)
          {
               if (begin + 1 == end)
               {
                    if (arr[begin] < arr[end])
                         return end;
                    else
                         return begin;
               }
               if (begin == end)
                    return end;
               int i = begin + 1;
               int j = end;
               int pivot = begin;
               while (j > i)
               {
                    while (arr[i] <= arr[pivot])
                    {
                         if (i == end)
                              return pivot;
                         else
                              i++;
                    }
                    while (arr[j] > arr[pivot])
                         j--;
                    if (i < j)
                         ToolBox.Tools.Swap(ref arr[i], ref arr[j]);
               }
               ToolBox.Tools.Swap(ref arr[j], ref arr[pivot]);
               return largest(ref arr, j + 1, end);
          }
     }
}
