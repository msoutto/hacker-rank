using System;

namespace SplitTape
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 1, 2, 4, 3 };
            Console.WriteLine(solution(A));
        }

        static int solution(int[] A)
        {
            int arraySum = sumArray(A);
            int leftSum = 0;
            int rightSum;
            int diff = Int32.MaxValue;

            for (int p = 1; p < A.Length; p++)
            {
                // Last elem before p
                leftSum += A[p - 1];
                // leftSum + rightSum = arraySum
                rightSum = arraySum - leftSum;

                int curDiff = Math.Abs(leftSum - rightSum);

                if (curDiff < diff)
                    diff = curDiff;
            }

            return diff;

            /*
            int result = Int32.MaxValue;

            for (int p = 1; p < A.Length; p++)
            {
                int[] left = new int[p];
                int[] right = new int[A.Length - p];
                Array.Copy(A, 0, left, 0, left.Length);
                Array.Copy(A, p, right, 0, right.Length);

                int diff = difference(left, right);

                if (diff < result)
                    result = diff;
            }

            return result;
            */
        }

        static int difference(int[] A, int[] B)
        {
            return Math.Abs(sumArray(A) - sumArray(B));
        }

        static int sumArray(int[] A)
        {
            int sum = 0;

            foreach(int elem in A)
            {
                sum += elem;
            }

            return sum;
        }
    }
}
