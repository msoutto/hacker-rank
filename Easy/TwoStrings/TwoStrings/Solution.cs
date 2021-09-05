using System;
using System.Collections.Generic;

namespace TwoStrings
{
    class Result
    {

        /*
         * Complete the 'twoStrings' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s1
         *  2. STRING s2
         */

        public static string twoStrings(string s1, string s2)
        {
            // Key: char from string1
            // (DON´T NEED TO COUNT) Value: times this char is found in string1
            Dictionary<char, int> dict = new Dictionary<char, int>();

            char[] arr1 = s1.ToCharArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!dict.ContainsKey(arr1[i]))
                    dict.Add(arr1[i], 0);
                //if (dict.ContainsKey(arr1[i]))
                //    dict[arr1[i]]++;
                //else
                //    dict.Add(arr1[i], 1);
            }

            char[] arr2 = s2.ToCharArray();

            foreach (char item in arr2)
            {
                if (dict.ContainsKey(item))
                    return "YES";
            }
            return "NO";
        }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = Result.twoStrings(s1, s2);

                Console.WriteLine(result);
            }
        }
    }
}
