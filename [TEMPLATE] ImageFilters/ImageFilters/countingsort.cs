using System;
using System.Collections.Generic;
using System.Text;

namespace ImageFilters
{
	class countingsort
	{
		static public  int[] CountingSort(int [] input)
        {
            // O(1)
           int max = input[0];

            // O(N)
            for (int i = 0; i < input.Length; i++)
            {
               if (input[i] > max)
                {
                    max = input[i];
                }
            }

            // Space complexity O(N+K)
            int[] counts = new int[max + 1];
            int[] output = new int[input.Length];


            // O(N)
            for (int i = 0; i < input.Length; i++)
            {
                counts[input[i]]++;
            }

            int j=0;
            // O(N+K)
            for (int i = 0; i < counts.Length; i++)
            {
                while (counts[i] > 0)
                {
                    output[j] = i;
                    j++;
                    counts[i]--;
                }
            }

            return output;
        }
    }

	}

