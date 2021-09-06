using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int unsortedItem;

            // Starts at the unsorted part of the array
            for (int i = 1; i < arr.Length; i++)
            {
                // j is the index of the sorted part of the array
                // initially we consider the first element to be the sorted part
                int j = i - 1;
                unsortedItem = arr[i];

                while (j >= 0 && arr[j] > unsortedItem)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Insert the unsortedItem in its correct position,
                // being now in the sorted part of the array (also being sorted)
                arr[j + 1] = unsortedItem;
            }
        }
    }
}
