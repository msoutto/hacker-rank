using System;

namespace MSAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = new string[] { "100", "110", "010", "011", "100" };
            string[] arr2 = new string[] { "0011", "0111", "0111", "0110", "0000" };

            Solution2 sol2 = new Solution2();

            Console.WriteLine($"arr1 result: " +
                $"{String.Concat(Array.ConvertAll(sol2.solution(arr1), item => $"{item} "))}");
            Console.WriteLine($"arr2 result: " +
                $"{String.Concat(Array.ConvertAll(sol2.solution(arr2), item => $"{item} "))}");

            //string s1 = "acbcbba";
            //string s2 = "axxaxa";
            //string s3 = "aaaa";
            //
            //Solution3 sol3 = new Solution3();
            //
            //Console.WriteLine($"s1 result: {sol3.solution(s1)}");
            //Console.WriteLine($"s2 result: {sol3.solution(s2)}");
            //Console.WriteLine($"s3 result: {sol3.solution(s3)}");
        }
    }
}
