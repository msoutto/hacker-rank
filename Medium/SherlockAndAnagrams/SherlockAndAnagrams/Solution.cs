using System;
using System.Collections.Generic;

namespace SherlockAndAnagrams
{
    class Result
    {

        /*
         * Complete the 'sherlockAndAnagrams' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int sherlockAndAnagrams(string s)
        {
            // A signature will be the sorted form of the substring
            // Example: signature of "mom" is "mmo", and signature of "omm" should be the same "mmo"

            // Key: signature of a substring
            // Value: number of substrings of s with this signature
            Dictionary<string, int> signatures = new Dictionary<string, int>();
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                
                string curString = s[i..]; //same as: s.Substring(i, s.Length - i)

                for (int j = 1; j <= curString.Length; j++)
                {
                    string substr = curString.Substring(0, j);
                    
                    if (!s.Equals(substr))
                    {
                        // Signature of substring
                        string sig = getSignature(substr);

                        if (signatures.ContainsKey(sig))
                            signatures[sig]++;
                        else
                            signatures[sig] = 1;

                    }
                }
            }

            Console.WriteLine("---- RESULTS ----");

            foreach (string sig in signatures.Keys)
            {
                Console.WriteLine($"['{sig}': {signatures[sig]}]");
                
                int n = signatures[sig];
                result += n * (n - 1) / 2;
            }
            
            return result;
        }

        static string getSignature(string s)
        {
            char[] charArray = s.ToCharArray();

            // A signature of a string will be the sorted form of the string
            Array.Sort(charArray);

            return String.Concat(charArray);
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = Result.sherlockAndAnagrams(s);

                Console.WriteLine(result);
            }

        }
    }
}
