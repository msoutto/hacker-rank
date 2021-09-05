using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Heap x = new MaxHeap();

            x.Add(13);
            x.Add(20);
            x.Add(9);
            x.Add(7);
            x.Add(8451);
            x.Add(1010);
            x.Add(4900);

            Console.WriteLine(String.Concat(Array.ConvertAll(x.Items.ToArray(), item => $"{item} ")));

            while (x.Length() > 0)
            {
                Console.WriteLine(x.Poll());
            }
        }
    }
}
