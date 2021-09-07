using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    public static class MergeSort
    {
        public static void Sort(int[] arr)
        {
            // Sharing the result array across all the process
            // for it not to be creating the same array on every iteration
            int[] temp = new int[arr.Length];
            Sort(arr, temp, 0, arr.Length - 1);
        }

        public static void Sort(int[] arr, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(arr, temp, left, middle); 
                Sort(arr, temp, middle + 1, right);
                Merge(arr, temp, left, right);
            }
        }

        public static void Merge(int[] arr, int[] temp, int leftStart, int rightEnd)
        {
            // Middle
            int leftEnd = (leftStart + rightEnd) / 2;
            int rightStart = leftEnd + 1;
            int length = rightEnd - leftStart + 1;

            int left = leftStart, right = rightStart, i = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (arr[left] < arr[right])
                {
                    temp[i] = arr[left];
                    left++;
                }
                else
                {
                    temp[i] = arr[right];
                    right++;
                }
                i++;
            }

            // Elements left on the left side. If the left side ended first,
            // number of elements (leftEnd - left + 1) will be 0
            Array.Copy(arr, left, temp, i, (leftEnd - left + 1));
            // Elements left on the right side. If the right side ended first,
            // number of elements (rightEnd - right + 1) will be 0
            Array.Copy(arr, left, temp, i, (rightEnd - right + 1));
            // Overwrite actual array with sorted (temp) array
            Array.Copy(temp, leftStart, arr, leftStart, length);
        }
    }
}
