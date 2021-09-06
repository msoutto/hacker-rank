using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1000, 2000, 1500, 500, 100, 300 };
            int[] arr2 = new int[] { 20, 38, 10, 29, 33, 50, 15 };

            Console.Write("arr1: ");
            Console.WriteLine(String.Concat(Array.ConvertAll(arr1, item => $"{item} ")));
            QuickSort.Sort(arr1);
            Console.Write("sorted arr1: ");
            Console.WriteLine(String.Concat(Array.ConvertAll(arr1, item => $"{item} ")));

            Console.Write("arr2: ");
            Console.WriteLine(String.Concat(Array.ConvertAll(arr2, item => $"{item} ")));
            QuickSort.Sort(arr2);
            Console.Write("sorted arr2: ");
            Console.WriteLine(String.Concat(Array.ConvertAll(arr2, item => $"{item} ")));

        }
    }
}
