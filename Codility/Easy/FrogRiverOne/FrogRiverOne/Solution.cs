using System;
using System.Collections.Generic;

namespace FrogRiverOne
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 1, 4, 2, 3, 5, 4, 2, 5, 6, 4, 2, 7, 6, 3 };
            int X = 7;
            Console.WriteLine(solution(X, A));
        }

        static int solution(int X, int[] A)
        {
            HashSet<int> positionsLeft = new HashSet<int>();

            getPositions(X, ref positionsLeft);

            for (int i = 0; i < A.Length; i++)
            {
                if (positionsLeft.Contains(A[i]))
                    positionsLeft.Remove(A[i]);

                if (positionsLeft.Count == 0)
                    return i;
            }

            return -1;
        }

        static void getPositions(int X, ref HashSet<int> result)
        {
            if (X > 0)
            {
                result.Add(X);
                getPositions(X - 1, ref result);
            }
        }
    }
}
