using System;
using System.Collections.Generic;

namespace CountingValleys
{
    class Result
    {

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int CountingValleys(int steps, string path)
        {
            if (path.Length != steps)
                throw new ArgumentException("Number of steps different than path length.");

            char[] stepArray = path.ToCharArray();

            int level = 0, result = 0;

            foreach(char direction in stepArray)
            {
                if (direction.Equals('D'))
                {
                    level--;
                }
                else if (direction.Equals('U'))
                {
                    if (level == -1)
                        result++;
                    level++;
                }
                else
                    throw new ArgumentException("Steps diferent than U and D.");

            }

            return result;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Result.CountingValleys(steps, path);

            Console.WriteLine(result);

            /*textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
