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
          private static int elementAt(List<byte> A, int k, List<byte> m)
          {
               int n;
               int pivot;
               List<byte> A1 = new List<byte>();
               List<byte> A2 = new List<byte>();
               n = A.Count;
               if (A.Count != m.Count)
                    pivot = A[0];
               else
                    pivot = 0;
               for (byte i = 0; i < n; i++)
               {
                    if (A.Count == m.Count)
                    {
                         if (A[i] < A[pivot])
                              A1.Add(i);
                         else if (A[i] > A[pivot])
                              A2.Add(i);
                    }
                    else
                    {
                         if (m[A[i]] < m[pivot])
                              A1.Add(A[i]);
                         else if (m[A[i]] > m[pivot])
                              A2.Add(A[i]);
                    }

               }

               if (k <= A1.Count)
                    return elementAt(A1, k, m);
               else if (k > A.Count - A2.Count)
                    return elementAt(A2, k - (A.Count - A2.Count), m);
               else
                    return pivot;
          }
     }
}
