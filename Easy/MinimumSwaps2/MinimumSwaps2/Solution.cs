using System;

namespace MinimumSwaps2
{
    class Solution
    {
        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                // Array should always be {1,2,3,...,n} (challenge description)
                while (arr[i] > i + 1)
                {
                    // If it is greater, swap with its correct position
                    Console.WriteLine("Swap({0},{1})", i, arr[i] - 1);
                    swap(ref arr, i, arr[i] - 1);
                    Console.WriteLine(String.Concat(Array.ConvertAll(arr, item => $"{item} ")));
                    count++;
                }
            }

            return count;
        }

        static void swap(ref int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int res = minimumSwaps(arr);

            Console.WriteLine(res);
        }
    }
}
