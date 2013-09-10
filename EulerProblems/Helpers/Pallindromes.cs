using System;
using System.Collections.Generic;

namespace EulerProblems.Helpers
{
    public class Pallindromes
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

    }
}


