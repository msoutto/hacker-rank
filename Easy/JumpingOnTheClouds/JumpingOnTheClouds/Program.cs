using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        // Always try to jump 2 first, to get the minimum number of jumps

        static int JumpingOnClouds(int[] c)
        {
            int result = 0;

            for (int index = 0; index < c.Length - 1; index++)
            {
                if (index + 2 < c.Length && c[index + 2] == 0)
                {
                    index++; // Skip two, instead of only one
                }
                result++;
            }

            return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = JumpingOnClouds(c);

            Console.WriteLine(result);

            /*textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
