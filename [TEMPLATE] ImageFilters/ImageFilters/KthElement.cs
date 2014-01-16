using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
     class KthElement
     {
          public static byte[] sort(ref byte[] arr, int k)
          {
               int index;
               byte begin = 0;
               int end = arr.Length - 1;
               int length = arr.Length;
               List<byte> ar = new List<byte>(arr);
               for (int l = 0; l < k; l++)
               {
                    index = elementAt(ar, 1, ar, true, begin, end + 1);
                    Swap(ref arr[index], ref arr[begin]);
                    begin++;
                    ar = new List<byte>(arr);
                    index = elementAt(ar, length, ar, true, begin, end + 1);
                    Swap(ref arr[index], ref arr[end]);
                    end--;
                    ar = new List<byte>(arr);
               }
               // Console.Out.WriteLine(elementAt(ar, 1,ar,true));
               return arr;
          }

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
                         Swap(ref arr[i], ref arr[j]);
               }
               Swap(ref arr[j], ref arr[pivot]);
               return smallest(ref arr, begin, j);
          }
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
                         Swap(ref arr[i], ref arr[j]);
               }
               Swap(ref arr[j], ref arr[pivot]);
               return largest(ref arr, j + 1, end);
          }
          public static void Swap<T>(ref T lhs, ref T rhs)
          {
               T temp;
               temp = lhs;
               lhs = rhs;
               rhs = temp;
          }
          private static int elementAt(List<byte> A, int k, List<byte> m, bool first, byte pivot, int end)
          {
               int n;
               List<byte> A1 = new List<byte>();
               List<byte> A2 = new List<byte>();
               if (first)
                    n = end;
               else
                    n = A.Count;


               for (byte i = pivot; i < n; i++)
               {
                    if (!first)
                         pivot = A[0];
                    if (first)
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
                    return elementAt(A1, k, m, false, 0, end);
               else if (k > A.Count - A2.Count)
                    return elementAt(A2, k - (A.Count - A2.Count), m, false, 0, end);
               else
                    return pivot;
          }
     }
}
