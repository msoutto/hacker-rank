using System;

namespace CountJumps
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10, 85, 30));
        }

        static int solution(int X, int Y, int D)
        {
            //int difference = Y - X;
            // Complete module so division will round up
            //int completingMod = D - 1
            //int k = (difference + completingMod) / D
            //int k = (Y - X + D - 1) / D;

            return (Y - X + D - 1) / D;
            /*
            int counter = 0;

            while (X < Y)
            {
                X += D;
                counter++;
            }

            return counter;
            */
        }
    }
}
