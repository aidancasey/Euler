using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EulerProblems.Helpers;

namespace EulerProblems
{
    public class Problem5 : IProblem 
    {
        #region IProblem Members


        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        public string Solve()
        {

            return FastSolve();


           //to make it efficient lets get the unique factors of 20 (if its divisible by 2 we dont' need to test for multiples of 2 etc...
          //then count from 10 onwards till we find a number thats divisible by all unique factors..

            bool foundMatch = false;
            int number  = 10;

            //brute force but hey it works as a starting point
            List<int> uniqueNumbers = Enumerable.Range(2, 19).ToList();

            while (!foundMatch)
            {
                var matches = uniqueNumbers.Where(x=> number % x ==0).ToList();
                if  (matches.Count == uniqueNumbers.Count())
                {
                    foundMatch = true;
                }
                else
                {
                    number++;
                }
            }
            return number.ToString(CultureInfo.InvariantCulture);
        }

        #endregion

        public long GreatestCommonDivisor(long a, long b)
        {
            if (b == 0)
                return a;
            else
                return GreatestCommonDivisor(b, a % b);
        }



        // calculate LCM using simple formula based on GCD
        public long LowestCommonMultiple(long a, long b)
        {
            var gcd = GreatestCommonDivisor(a, b);
            return a * b / gcd;
        }


        //http://codereview.stackexchange.com/questions/25200/smallest-number-divisible-by-all-numbers-from-1-to-20-project-euler-question-5

        public string FastSolve()
        {
             long result = 1;

        // loop through each value 1 to 20, and LCM with previous result
        for (long n = 2; n <= 20; n++) {
            result = LowestCommonMultiple(result, n);
        }
            return result.ToString(CultureInfo.InvariantCulture);
        }

        
    }

}
