using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EulerProblems.Helpers;

namespace EulerProblems
{
    public class Problem5 : ISolveProblemManyWays 
    {
        #region IProblem Members


        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        public string Solve()
        {

            return AlgebraSolve();

        }

        #endregion

    public string LinqSolve()
    {

        bool foundMatch = false;
        var number = 10;

        //brute force but hey it works as a starting point
        List<int> uniqueNumbers = Enumerable.Range(2, 19).ToList();

        while (!foundMatch)
        {
            List<int> matches = uniqueNumbers.Where(x => number % x == 0).ToList();
            if (matches.Count == uniqueNumbers.Count())
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



        //http://codereview.stackexchange.com/questions/25200/smallest-number-divisible-by-all-numbers-from-1-to-20-project-euler-question-5

        public string AlgebraSolve()
        {
             long result = 1;

        // loop through each value 1 to 20, and LCM with previous result
        for (long n = 2; n <= 20; n++) {
            result = Numbers.LowestCommonMultiple(result, n);
        }
            return result.ToString(CultureInfo.InvariantCulture);
        }

        
    }

}
