using System;
using System.Collections.Generic;

namespace PermCheck
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 5, 3, 1, 4, 7, 9 };
            Console.WriteLine(solution(A));
        }

        static int solution(int[] A) 
        {
            HashSet<int> permutation = new HashSet<int>();

            getPermutation(A.Length, ref permutation);

            foreach (int elem in A)
            {
                if (permutation.Contains(elem))
                    permutation.Remove(elem);
            }

            return permutation.Count == 0 ? 1 : 0;
        }

        static void getPermutation(int elem, ref HashSet<int> permutation)
        {
            if (elem > 0)
            {
                permutation.Add(elem);
                getPermutation(elem - 1, ref permutation);
            }
        }
    }
}
