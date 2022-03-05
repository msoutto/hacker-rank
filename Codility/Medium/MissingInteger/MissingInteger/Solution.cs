using System;
using System.Collections.Generic;

namespace MissingInteger
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 5, 2, -3 };
            Console.WriteLine(solution(A));
        }

        static int solution(int[] A)
        {
            HashSet<int> positiveSet = new HashSet<int>();
            int smallestPositive = 1, greatestPositive = 1;

            foreach (int elem in A)
            {
                // Element is positive
                if (elem > 0)
                {
                    if (!positiveSet.Contains(elem))
                    {
                        // Fill positiveSet
                        positiveSet.Add(elem);
                        // Update greatestPositive
                        if (elem > greatestPositive)
                            greatestPositive = elem;
                    }
                }
            }

            // When set is empty, it means the array does not have any positive values
            if (positiveSet.Count == 0)
                return smallestPositive;

            for (int i = smallestPositive; i <= greatestPositive; i++)
            {
                if (!positiveSet.Contains(i))
                    return i;
            }

            // If array contains sequence, return next positive.
            // i.e [1, 2, 3, 4] -> return 5
            return greatestPositive + 1;
        }
    }
}
