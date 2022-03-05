using System;

namespace MaxCounters
{
    class Solution
    {
        static void Main(string[] args)
        {
            int N = 6;
            int[] operations = { 1, 4, 6, 2, 1, 7, 3, 7, 2 };

            int[] result = solution(N, operations);

            Console.WriteLine(String.Concat(Array.ConvertAll(result, item => $"{item} ")));
        }

        static int[] solution(int N, int[] A)
        {
            // Array starts filled with 0
            int[] counters = new int[N];

            int maxValue = 0;

            foreach (int operation in A)
            {
                if (operation == N + 1) // Max counter operation
                    Array.Fill(counters, maxValue);
                else
                {
                    // Increase operation
                    counters[operation - 1]++;
                    // Update maxValue
                    if (counters[operation - 1] > maxValue)
                        maxValue = counters[operation - 1];
                }
            }

            return counters;
        }
    }
}
