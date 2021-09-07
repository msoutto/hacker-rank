using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public static class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            int sorted = -1, minimum;

            for (int unsorted = 0; unsorted < arr.Length; unsorted++)
            {
                minimum = unsorted;
                for (int i = unsorted + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[minimum])
                        minimum = i;
                }

                sorted++;
                Swap(arr, sorted, minimum);
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
