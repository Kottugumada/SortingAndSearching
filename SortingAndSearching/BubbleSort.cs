using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
    class BubbleSort
    {
      public int[] sortArray(int[] arr)
        {
            int[] brr = arr;
            int changes = 0;
            for (int i = 0; i<arr.Length -1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    changes = changes + 1;
                }
            }
            if (changes == 0)
            {
                return arr;
            }
            else
            {
              return sortArray(arr);
            }
            
        }
        

    }
}
