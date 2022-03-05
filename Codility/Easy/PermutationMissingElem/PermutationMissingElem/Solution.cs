using System;
using System.Linq;

namespace PermutationMissingElem
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 3, 1, 5 };
            Console.WriteLine(solution(A));
        }

        static int solution(int[] A)
        {
            // 1 |   2  |   3  |   4   | ... | N - 1 | N
            // N | N - 1| N - 2| N - 3 | ... |   2   | 1
            // The sum of both lists would be N*(N+1),
            // so the sum of each list would be N*(N+1)/2, since they are the sam (reodered)
            // But in our case N would be A.Length + 1, because this would be the full list
            int N = A.Length + 1;
            int sum = N * (N + 1) / 2;
            int result = sum;

            foreach (int elem in A)
            {
                // In the end, the only item that did not subtract will be the result
                result -= elem;
            }

            return result;
        }

        static int OldSolution(int[] A)
        {
            // In this case, (N+1) = 1, there are no other numbers from 1 to 1
            if (A.Length == 0)
                return 1;

            int result;
            double product = 1, correctProduct = 1;

            for (int i = 0; i < A.Length; i++)
            {
                // Product will be the (N+1)!/K, where K is the missing item
                product *= A[i];
                correctProduct *= i + 1;
            }

            // Correct product will be (N+1)!
            correctProduct *= A.Length + 1;
            // (N+1)!/((N+1)!/K) = ((N+1)!*K)/(N+1)! = K
            result = (int)(correctProduct / product);

            return result;
        }
    }
}
