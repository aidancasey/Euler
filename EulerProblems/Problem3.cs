using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EulerProblems.Extensions;
using EulerProblems.Helpers;

namespace EulerProblems
{
    public class Problem3 : ISolveProblemManyWays  
    {
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //
        //  What is the largest prime factor of the number 600851475143


        //approach 1 - failed miserable . come up with an array of all the prime numbers less than half the size of the required number
        //them pump them thru and return find the largest ones with a mod 0
        //time to loop was too long


        public string Solve()
        {
            const long number = 600851475143;
            var primeNumbers = GeneratePrimeNmubers(number / 2);
           
            primeNumbers.Reverse();

            foreach (var i in primeNumbers.Where(i => number % i == 0))
            {
                return i.ToString(CultureInfo.InvariantCulture);
                break;
            }
            return null;
        }


        public string AlgebraSolve()
        {
            const long number = 600851475143;
            for (var j = (Math.Round( Math.Sqrt(number),0) +1);j>=2; j--)
            {
                if (IsPrimeNumber((long)j))
                {
                   if (number % j == 0)
                    {
                       return j.ToString(CultureInfo.InvariantCulture);
                        break;
                    }
                }
            }
            return null;
        }

        public string LinqSolve()
        {
             return Factors.GetFactors(600851475143).ToList().Where(x => x.IsPrime()).OrderBy(x => x).Last().ToString();
        }
        
        private List<long> GeneratePrimeNmubers(long maxNumber)
        {
            var allPrimeNumbers = new List<long>();

            for (long i = 1; i <= Math.Sqrt(maxNumber); i++)
            {
                if (IsPrimeNumber(i))
                {
                    allPrimeNumbers.Add(i);
                }
            }
            return allPrimeNumbers;
        }


        private bool IsPrimeNumber(long number)
        {
            if ((number == 0) || (number == 1)) return false;

            if (number == 2) return true;

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {

                if (i > number / 2)
                {
                    return true;
                }
                
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
