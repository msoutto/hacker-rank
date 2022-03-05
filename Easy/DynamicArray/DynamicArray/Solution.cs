using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> arr = new List<List<int>>(n);
        List<int> answers = new List<int>();
        int lastAnswer = 0;

        for (int i = 0; i < n; i++)
        {
            arr.Add(new List<int>());
        }

        foreach (List<int> query in queries)
        {
            switch (query[0])
            {
                case 1:
                    QueryOne(arr, query[1], query[2], ref lastAnswer);
                    break;
                case 2:
                    QueryTwo(arr, query[1], query[2], ref lastAnswer, ref answers);
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        return answers;
    }

    static void QueryOne(List<List<int>> arr, int x, int y, ref int lastAnswer)
    {
        int idx = (x ^ lastAnswer) % arr.Count;
        arr[idx].Add(y);
    }

    static void QueryTwo(List<List<int>> arr, int x, int y, ref int lastAnswer, ref List<int> answers)
    {
        int idx = (x ^ lastAnswer) % arr.Count;
        lastAnswer = arr[idx][y % arr[idx].Count];
        answers.Add(lastAnswer);
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = Result.dynamicArray(n, queries);

        Console.WriteLine(String.Join("\n", result));
    }
}