using System;
using System.Collections.Generic;
using System.Linq;

namespace RansomNote
{
    class Result
    {

        /*
         * Complete the 'checkMagazine' function below.
         *
         * The function accepts following parameters:
         *  1. STRING_ARRAY magazine
         *  2. STRING_ARRAY note
         */

        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string word in magazine)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict.Add(word, 1);
            }

            foreach (string word in note)
            {
                //Console.WriteLine(String.Concat(Array.ConvertAll(dict.Keys.ToList().ToArray(), item => $"({item}: {dict[item]}) ")));

                if (dict.ContainsKey(word))
                {
                    if (dict[word] > 1)
                        dict[word]--;
                    else
                        dict.Remove(word);
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(firstMultipleInput[0]);

            int n = Convert.ToInt32(firstMultipleInput[1]);

            List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

            List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

            Result.checkMagazine(magazine, note);
        }
    }
}
