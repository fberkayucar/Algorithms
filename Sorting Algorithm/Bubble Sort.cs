using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public class Bubble_Sort
    {
        public Bubble_Sort()
        {

        }
        public void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
    }
}
