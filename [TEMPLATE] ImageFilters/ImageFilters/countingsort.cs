using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
     class CountingSort
     {
          static public byte[] sort(byte[] input)
          {
               // O(1)
               byte max = input[0];
               int length = input.Length;


               // O(N)
               for (int i = 0; i < length; i++)
               {
                    if (input[i] > max)
                    {
                         max = input[i];
                    }
               }

               // Space complexity O(N+K)
               byte[] counts = new byte[max + 1];
               byte[] output = new byte[length];
               int length2 = counts.Length;

               // O(N)
               for (int i = 0; i < length; i++)
               {
                    counts[input[i]]++;
               }

               byte j = 0;
               // O(N+K)
               for (byte i = 0; i < length2; i++)
               {
                    bool flag = false;
                    while (counts[i] > 0)
                    {
                         if (i == 255)
                              flag = true;
                         output[j] = i;
                         j++;
                         counts[i]--;
                    }
                    if (flag == true)
                         break;
               }

               return output;
          }
     }

}

