using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
	class quicksort
	{
		static public int Partition(int[] numbers, int left, int right)
		{
			int pivot = numbers[left];
			while (true)
			{
				while (numbers[left] < pivot)
					left++;

				while (numbers[right] > pivot)
					right--;

                    if (left < right)
                        KthElement.Swap(ref numbers[left], ref numbers[right]);
                    else
                    {
                         return right;
                    }
			}
		}

		static public void QuickSort_Recursive(int[] arr, int left, int right)
		{
			// For Recusrion
			if (left < right)
			{
				int pivot = Partition(arr, left, right);

				if (pivot > 1)
					QuickSort_Recursive(arr, left, pivot - 1);

				if (pivot + 1 < right)
					QuickSort_Recursive(arr, pivot + 1, right);
			}
		}
	}
	}

