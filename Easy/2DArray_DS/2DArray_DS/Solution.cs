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
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    const int HOURGLASS_DIMENSION = 3;

    public static int hourglassSum(List<List<int>> arr)
    {
        // Pivot is the element in the first line and first column of hourglass
        // The last possible pivot is 2 lines before last and 2 columns before last
        int countLine = arr.Count - 2;
        int countColumn = arr[arr.Count - 2].Count - 2;

        int result = Int32.MinValue;

        for (int pivotLine = 0; pivotLine < countLine; pivotLine++)
        {
            for (int pivotColumn = 0; pivotColumn < countColumn; pivotColumn++)
            {
                int sum = hourglassSingle(arr, pivotLine, pivotColumn);
                if (sum > result)
                {
                    result = sum;
                }
            }
        }

        return result;
    }

    public static int hourglassSingle(List<List<int>> arr, int pivotLine, int pivotColumn)
    {
        int result = arr[pivotLine][pivotColumn] + arr[pivotLine][pivotColumn + 1] + arr[pivotLine][pivotColumn + 2];
        result += arr[pivotLine + 1][pivotColumn + 1];
        result += (arr[pivotLine + 2][pivotColumn] + arr[pivotLine + 2][pivotColumn + 1] + arr[pivotLine + 2][pivotColumn + 2]);

        return result;
    }

}

namespace _2DArray_DS
{
    class Solution
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.hourglassSum(arr);

            Console.WriteLine(result);

        }
    }
}
