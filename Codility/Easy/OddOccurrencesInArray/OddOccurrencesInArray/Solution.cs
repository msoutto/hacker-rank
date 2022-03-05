using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrencesInArray
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 3, 9, 3, 7 };

            Console.WriteLine(solution(a));
        }

        static int solution(int[] A)
        {
            // Single item will be the odd
            if (A.Length == 1)
                return A[0];

            // Keep odd values
            Dictionary<int, int> oddValues = new Dictionary<int, int>();

            foreach (int value in A)
            {
                // If we already have value in the set,
                // it means this is a pair
                if (oddValues.ContainsKey(value))
                    oddValues.Remove(value);
                else
                    oddValues[value] = 1;
            }

            // Return the only remaining key in the dictionary
            return oddValues.First(x => x.Value == 1).Key;
        }
    }
}
