using System;
using System.Collections.Generic;
using System.Text;

namespace MSAssessment
{
    class Solution1
    {
        public int solution(int N)
        {
            List<int> digits = GetDigits(N);

            int sum = GetSum(digits);

            return GetIntFromDigits(GetResultDigits(digits, sum));
        }

        public List<int> GetResultDigits(List<int> digits, int sum)
        {
            int resultSum = sum * 2, curSum = sum, lastDigit = 9;

            if (resultSum > digits.Count * 9)
                return null;

            List<int> resultDigits = new List<int>(digits);

            for (int i = digits.Count - 1; i >= 0; i--)
            {
                curSum -= digits[i];

                //if (resultSum - curSum)

                for (int j = 9; j >= 0; j--)
                {
                    if (curSum + j > resultSum)
                    {
                        lastDigit = j;
                    }
                    else if (curSum + j < resultSum)
                    {
                        curSum += lastDigit;
                        resultDigits[i] = lastDigit;
                        break;
                    }
                    else
                    {// curSum + j == resultSum
                        resultDigits[i] = j;
                        return resultDigits;
                    }
                }
            }

            return null;
        }

        public int GetSum(List<int> list)
        {
            int result = 0;

            foreach (int item in list)
            {
                result += item;
            }

            return result;
        }

        public List<int> GetDigits(int n)
        {
            //This will hold the list of digits of n
            List<int> result = new List<int>();

            while (n > 0)
            {
                // Get last digit
                int digit = n % 10;
                // Update n, since we already got the last digit
                n /= 10;

                result.Add(digit);
            }

            // The digits will be in a reversed order, so we have to reverse it back
            result.Reverse();
            return result;
        }

        int GetIntFromDigits(List<int> digits)
        {
            int result = 0;

            if (digits != null)
            {
                for (int i = digits.Count - 1; i >= 0; i--)
                {
                    result += digits[i] * (int)Math.Pow(10, digits.Count - 1 - i);
                }
            }

            return result;
        }
    }
}
