using System;
using EulerProblems.Extensions;

namespace EulerProblems
{
    public class Problem10 : ISolveProblemManyWays
    {
        public string Solve()
        {
            long total = 0;
           for(int i= 2; i<2000000;i++)
            {
                if (i.IsPrime())
                {
                    total += i;
                }

            }

            return total.ToString();

        }

        public string LinqSolve()
        {
            return "not implemented";
        }

        public string AlgebraSolve()
        {
            //to do implement Sieve of Eratosthenes

            //   http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
            
            return "not implemented";

        }
    }
}
