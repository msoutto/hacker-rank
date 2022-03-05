using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public static void Main(string []args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result:");
        Console.WriteLine(solution(N));
    }

    public static int solution(int N)
    {
        // For comparison reasons, we need the absolute value
        int current = Math.Abs(N);
        int gap = 0;

        // Get the power of 2 closest to current value
        int logClosestPower = (int) Math.Log(current, 2);
        int closestPower = (int) Math.Pow(2, logClosestPower);

        // Get the rest/difference between current value and closestPower
        int rest = current - closestPower;

        while (rest > 0)
        {
            // Get power of 2 closest to the rest
            int logClosestPowerRest = (int) Math.Log(rest, 2);

            // Number of powers of 2 between the closest power 
            // and the closest power of the rest
            int currentGap = logClosestPower - logClosestPowerRest - 1;
            // Update gap if currentGap is greater
            gap = currentGap > gap ? currentGap : gap;

            // Update our current number being analyzed
            current = rest;

            // Get power of 2 closest to current
            logClosestPower = (int) Math.Log(current, 2);
            closestPower = (int) Math.Pow(2, logClosestPower);

            rest = current - closestPower;
        }

        return gap;
    }
}
