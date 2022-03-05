using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 7, 8, 2, 0, 4, 6 };
            int[] arr2 = new int[] { 20, 16, 40, 8, 32, 9 };

            Console.Write("arr1: ");
            Console.WriteLine(String.Concat(Array.ConvertAll(arr1, item => $"{item} ")));
            SelectionSort.Sort(arr1);
            Console.Write("sorted arr1: ");
            Console.WriteLine(String.Concat(Array.ConvertAll(arr1, item => $"{item} ")));

            Console.Write("arr2: ");
            Console.WriteLine(String.Concat(Array.ConvertAll(arr2, item => $"{item} ")));
            SelectionSort.Sort(arr2);
            Console.Write("sorted arr1: ");
            Console.WriteLine(String.Concat(Array.ConvertAll(arr2, item => $"{item} ")));
        }
    }
}
