using System;
using Selection;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[15];

            Random random = new Random();
            // Fill arrays
            for (int i = 0; i < arr1.Length; i++) arr1[i] = random.Next(arr1.Length);
            for (int i = 0; i < arr2.Length; i++) arr2[i] = random.Next(arr2.Length);

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
