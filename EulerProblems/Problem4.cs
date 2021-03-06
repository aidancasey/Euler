﻿using System.Collections.Generic;
using System.Linq;
using EulerProblems.Helpers;

namespace EulerProblems
{
    public class Problem4 : ISolveProblemManyWays 
    {
        #region IProblem Members

        /*
        // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.
         */

        public string Solve()
        {


           // get all pallindromes less than 1000 * 1000 in size
            List<int> pallindromeNums = Numbers.GetPalindromeNumbers(6).OrderByDescending(x => x).ToList();
                      
            int result = 0;

            // for each one check if a numers between 100->1000  divide in evenly
            foreach (var number in pallindromeNums)
            {
                for (var i = 1000; i >= 100; i--)
                {
                    if ((number % i) == 0)
                    {
                        result = number/i;
                        if (result.ToString().Length == 3)                        
                        {
                            return (string.Format("Bingo : {0} = {1} X {2}", number, i, result));
                        }
                    }

                }
            }

          //numbers must be below the square root of the number
            return "couldn't solve problem";
        }

        public string  LinqSolve()
        {
            var factors = Enumerable.Range(100, 900);
            var maxlargestPallindrome = factors.SelectMany(x => factors.Select(y => x * y)).Where(x => x.ToString().Reverse().SequenceEqual(x.ToString())).Max();
            return maxlargestPallindrome.ToString();
        }


        public string AlgebraSolve()
        {
            int largestNumber = 0;
            for (int x = 100; x <= 1000; x++)
            {
                for (int y = 100; y <= 1000; y++)
                {
                    int result = x * y;
                    string resultString = result.ToString();

                    if (Utils.Reverse(resultString) == resultString)
                    {
                        if (result > largestNumber)
                        {
                            largestNumber = result;
                        }

                    }
                }
            }   
            return largestNumber.ToString();
        }

        #endregion
    }
}
