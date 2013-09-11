using System;
using System.Collections.Generic;

namespace EulerProblems.Helpers
{
    public class Numbers
    {

        public static IEnumerable<int> GetPalindromeNumbers(int numOfDigits)
        {
            int maxNumber = (int)Math.Pow(10, numOfDigits) - 1;

            var pallindromeNumbers = new List<int>();

            for (int i = 10; i <= maxNumber; i++)
            {
                if (i.ToString() == Utils.Reverse(i.ToString()))
                    pallindromeNumbers.Add(i);
            }
            return pallindromeNumbers;
        }

        public static long SumSquareFirstNNaturalNumbers(long n)
        {
            var result = (n * (n + 1) * (2 * n + 1)) / 6;
            return result;
        }

        public static double SumFirstNNaturalNumbers(int n)
        {
            var result = (n * (n + 1)) / 2;
            return result;
        }


        public static long GreatestCommonDivisor(long a, long b)
        {
            if (b == 0)
                return a;
            else
                return GreatestCommonDivisor(b, a % b);
        }



        // calculate LCM using simple formula based on GCD
        public static long LowestCommonMultiple(long a, long b)
        {
            var gcd = GreatestCommonDivisor(a, b);
            return a * b / gcd;
        }

    }
}


