using System.Globalization;
using System.Linq;
using EulerProblems.Extensions;

namespace EulerProblems
{
    public class Problem7 : ISolveProblemManyWays
    {
        #region ISolveProblemManyWays Members

        public string LinqSolve()
        {
            return
                Enumerable.Range(2, int.MaxValue - 1)
                          .Select(x => x)
                          .Where(x => x.IsPrime())
                          .Skip(10000)
                          .FirstOrDefault()
                          .ToString(CultureInfo.InvariantCulture);
        }

        public string AlgebraSolve()
        {
            return "not implemented";

        }

        #endregion

        #region IProblem Members

//        By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//       What is the 10001st prime number?

        public string Solve()
        {
            var count = 0;
            var i = 1;
            while ((count < 10001)) 
            {
                i++;
                if (i.IsPrime())
                {
                    count++;
                }
            } 
            return i.ToString(CultureInfo.InvariantCulture);
        }

        #endregion
    }
}
