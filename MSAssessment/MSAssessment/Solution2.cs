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
            int numberBase = 2;
            int greater = Convert.ToInt32(carOne, numberBase);
            int lesser = Convert.ToInt32(carTwo, numberBase);

            if (greater < lesser)
            {
                int temp = lesser;
                lesser = greater;
                greater = temp;
            }

            int difference = greater - lesser;

            // Both params are equal
            if (difference == 0) return true;

            // The difference must be a power of 2. E.g: [01, 11], [1001, 1101]... 
            double log = Math.Log(difference, numberBase);

            // Log is an integer number, so difference is a power of 2
            if (log % 1 == 0)
            {
                if (lesser % 2 > 0)
                {// lesser is odd
                    // Only one digit can be changed (difference cannot be 1)
                    if (difference != 1) return true;

                }
                else
                {// lesser is even
                 // Params only differ by one bit. E.g: [10, 11], [1100, 1101]...
                 //if (difference == 1) return true;

                    // If difference is the same as lesser, then it would change 2 digits
                    // The difference must not be the same as lesser. E.g: [010, 100], [0100, 1000]...
                    // The difference can be 1. E.g: [010, 011], [01100, 01101]...
                    if (difference != lesser) return true;
                }
            }

            return false;
        }

        bool OldAreSimilar(string carOne, string carTwo)
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
