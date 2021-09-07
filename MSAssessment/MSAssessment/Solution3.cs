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
            Dictionary<char, int> oddDict = new Dictionary<char, int>();

            foreach (char c in arr)
            {
                // If it already contains one and there is this other one,
                // the number of letters c is even, so remove from oddDict
                if (oddDict.ContainsKey(c))
                {
                    oddDict.Remove(c);
                }
                // If it does not contain, then it is a new letter (odd)
                else
                {
                    oddDict.Add(c, 1);
                }
            }

            return oddDict.Keys.Count;
        }
    }
}
