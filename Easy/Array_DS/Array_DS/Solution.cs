using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_DS
{
    class Result
    {

        /*
         * Complete the 'reverseArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static List<int> reverseArray(List<int> a)
        {
            // Could just call this method
            // a.Reverse();

            for (int i = 0; i < a.Count / 2; i++)
            {
                int temp = a[i];
                a[i] = a[a.Count - 1 - i];
                a[a.Count - 1 - i] = temp;
            }

            return a;
        }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> res = Result.reverseArray(arr);

            Console.WriteLine(String.Join(" ", res));
        }
    }
}
