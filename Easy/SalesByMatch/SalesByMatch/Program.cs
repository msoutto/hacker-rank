using System;
using System.IO;
using System.Collections.Generic;

namespace SalesByMatch
{
    class Solution
    {

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            HashSet<int> odd = new HashSet<int>();
            IList<int> pairs = new List<int>();
            for (int item = 0; item < ar.Length; item++)
            {
                if (odd.Contains(ar[item]))
                {
                    pairs.Add(ar[item]);
                    odd.Remove(ar[item]);
                }
                else
                {
                    odd.Add(ar[item]);
                }
            }

            return pairs.Count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

            /*textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();*/
        }
    }

}
