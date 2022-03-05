using System;

namespace CyclicRotation
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 8, 9, 7, 6 };
            int k = 3;

            Console.WriteLine("Result:");
            Console.WriteLine(String.Concat(Array.ConvertAll(solution(a, k), item => $"{item} ")));
        }

        static int[] solution(int[] A, int K)
        {
            // Array is empty or single, rotating it will be the same
            if (A.Length == 0 || A.Length == 1)
                return A;

            // Rotating A.Length times will keep the array the same
            K %= A.Length;

            int[] result = new int[A.Length];

            // First index of the right side
            int right = A.Length - K;

            // Copy the right side of source into the left side of destination
            Array.Copy(A, right, result, 0, K);

            Console.WriteLine(String.Concat(Array.ConvertAll(result, item => $"{item} ")));

            // Copy the left side of source into the right side of destination
            Array.Copy(A, 0, result, K, right);

            Console.WriteLine(String.Concat(Array.ConvertAll(result, item => $"{item} ")));

            return result;
        }
    }
}
