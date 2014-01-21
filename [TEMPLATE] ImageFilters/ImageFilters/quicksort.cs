using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
     class quicksort
     {
          static public int Partition(byte[] numbers, int left, int right)
          {
			  int pivot = numbers[left];
			  int i = left;
			  int j = right;
			  byte temp;
			  while (true)
			  {
				  if (numbers[i] <= pivot)
					  i++;
				  if (numbers[j] >= pivot)
					  j--;
				  if (i < j && numbers[i] > numbers[j])
				  {
                           ToolBox.Tools.Swap(ref numbers[i],ref  numbers[j]);
				  }
				  else if (i > j)
					  break;
			  }
			  temp = numbers[j];
			  numbers[j] = numbers[left];              //swap pivot arr[j] aly hwa as8ar rakm
			  numbers[left] = temp;
			  return j;
          }

          static public void QuickSort_Recursive(byte[] arr, int left, int right)
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

