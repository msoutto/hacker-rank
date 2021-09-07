using System;

namespace Bubble
{
    public static class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // arr.Length - i - 1 is the sorted part, as the iterations happen
                // the greatest element will be pushed to the last index
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(arr, j, j + 1);
                }
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
