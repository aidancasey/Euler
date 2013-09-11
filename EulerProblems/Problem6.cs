using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerProblems.Helpers;

namespace EulerProblems
{
    public class Problem6 : ISolveProblemManyWays 
    {
        #region IProblem Members

        /*

        The sum of the squares of the first ten natural numbers is,

        12 + 22 + ... + 102 = 385

        The square of the sum of the first ten natural numbers is,

        (1 + 2 + ... + 10)2 = 552 = 3025
        
        Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

         */

          

        public string Solve()
        {
            double sumsq = 0, sqsum = 0;

            for (int i = 0; i <= 100; i++)
            {
                sqsum += i;
                sumsq += Math.Pow(i, 2);
            }
            sqsum *= sqsum;
            return (sqsum - sumsq).ToString(CultureInfo.InvariantCulture);
        }

        public string AlgebraSolve()
        {
            double sum = Numbers.SumFirstNNaturalNumbers(100);
            var result = Numbers.SumSquareFirstNNaturalNumbers(100) - Math.Pow(sum, 2);
            return result.ToString(CultureInfo.InvariantCulture);

        }

        public string LinqSolve()
        {        
            return (Math.Pow(Enumerable.Range(1,100).Sum(),2) - Enumerable.Range(1,100).Sum(n=>n*n)).ToString(CultureInfo.InvariantCulture);
        }

        #endregion
    }
}
