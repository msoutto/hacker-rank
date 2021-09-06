using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    public static class QuickSort
    {
        public static void Sort(int[] arr, int low = 0, int high = Int32.MaxValue)
        {
            if (high > arr.Length - 1)
                high = arr.Length - 1;


            if (low < high)
            {
                int pi = Partition(arr, low, high);

                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            // My little improvement... :)
            if (arr[low] > arr[high])
                Swap(arr, low, high);

            int j = low - 1;

            for (int i = low; i < high; i++)
            {// Is the current item greater than pivot?
                if (arr[i] <= arr[high])
                {// Swap current with the position in front of the last swapped
                 // (last item less than pivot)
                    j++;
                    Swap(arr, i, j);
                }
            }
            // Swap the pivot with the position in front of the last swapped
            // (last item less than pivot)
            j++;
            Swap(arr, j, high);

            return j;
        }

        static void Swap(int[] arr, int index1, int index2)
        {
            if (index1 != index2)
            {
                int temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;
            }
        }
    }
}
