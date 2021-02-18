using System;

namespace RepeatedString
{
    class Program
    {
        static int CountAs(string s)
        {
            int asInString = 0;

            foreach (char item in s.ToCharArray())
            {
                if (item.Equals('a'))
                    asInString++;
            }

            return asInString;
        }

        static long RepeatedString(string s, long n)
        {
            long numberOfCompleteStrings = (n / s.Length);
            int remainder = (int)(n % s.Length);

            long asInString = CountAs(s);

            long result = (numberOfCompleteStrings * asInString) + CountAs(s.Substring(0, remainder));

            return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = RepeatedString(s, n);

            Console.WriteLine(result);

            /*textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
