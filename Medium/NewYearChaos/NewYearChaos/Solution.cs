using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace NewYearChaos
{
    class Result
    {

        /*
         * Complete the 'minimumBribes' function below.
         *
         * The function accepts INTEGER_ARRAY q as parameter.
         */

        public static void minimumBribes(List<int> q)
        {
            int count = 0;

            for (int i = 0; i < q.Count; i++)
            {
                // Makes the calculations easier to understand: q[0] = 0, q[1] = 1, ...
                q[i]--;

                // The items can only bribe 2 times...
                // The item in q[i] could not be more than 2 positions ahead of its initial position
                if (q[i] - i > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                // Who bribed q[i] cannot be more than 1 position ahead of i (q[i]'s initial position)
                // X bribing once, it should be at i position (X swapped q[i])
                // X briging twice, it should be at i-1 position (X swapped q[i], then swapped q[i-1])
                for (int j = Math.Max(q[i] - 1, 0); j < i; j++)
                {// Iterate until 1 position ahead of i (i - 1)
                    if (q[j] > q[i])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

                Result.minimumBribes(q);
            }
        }
    }
}
