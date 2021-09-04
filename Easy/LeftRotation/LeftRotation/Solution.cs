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

class Result
{

    /*
     * Complete the 'rotLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER d
     */

    public static List<int> rotLeft(List<int> a, int d)
    {
        int times = d;

        // Rotating left list.Count times, the list keeps the same
        if (times > a.Count - 1)
        {
            times = d % (a.Count - 1);
        }
        return LeftRotation(a, times);
    }

    public static List<int> LeftRotation(List<int> a, int d)
    {
        List<int> result = a.GetRange(d, a.Count - d);

        result.AddRange(a.GetRange(0, d));

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> result = Result.rotLeft(a, d);

        Console.WriteLine(String.Join(" ", result));
    }
}
