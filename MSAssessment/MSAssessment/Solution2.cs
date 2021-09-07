using System;
using System.Collections.Generic;
using System.Text;

namespace MSAssessment
{
    class Solution2
    {
        public int[] solution(string[] cars)
        {
            int[] result = new int[cars.Length];

            for (int i = 0; i < cars.Length; i++)
            {
                // Once index i is compared with all the rest of the array,
                // we don´t need to compare other indexes with i
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (AreSimilar(cars[i], cars[j]))
                    {
                        // Update both indexes, for us not to compare
                        // indexes more than once
                        result[i]++;
                        result[j]++;
                    }
                }
            }

            return result;
        }

        bool AreSimilar(string carOne, string carTwo)
        {
            // Separate each char/feature of the cars to compare them
            char[] arrOne = carOne.ToCharArray();
            char[] arrTwo = carTwo.ToCharArray();
            // Counter for number of differences
            int difference = 0;

            for (int i = 0; i < arrOne.Length; i++)
            {
                if (!arrOne[i].Equals(arrTwo[i]))
                    difference++;

                if (difference > 1)
                    return false;
            }

            return true;
        }
    }
}
