using System;
using System.Collections.Generic;
using System.Text;

namespace MSAssessment
{
    class Solution3
    {
        public int solution(string S)
        {
            // Get array of letters
            char[] arr = S.ToCharArray();
            // Used to check odd chars in string
            HashSet<char> oddSet = new HashSet<char>();

            foreach (char c in arr)
            {
                // If it already contains one and there is this other one,
                // the number of letters c is even, so remove from oddDict
                if (oddSet.Contains(c))
                    oddSet.Remove(c);
                else // If it does not contain, then it is a new letter (odd)
                    oddSet.Add(c);
            }

            return oddSet.Count;
        }
    }
}
