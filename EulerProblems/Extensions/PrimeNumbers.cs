using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class PrimeNumbers
    {
        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        /// <param name="candidate">Potential prime number</param>
        /// <returns>true if prime</returns>
        public static bool IsPrime(this int candidate)
        {
            return CheckForPrimeness(candidate);
        }

        /// <summary>
        /// Determines if a number is prime
        /// </summary>
        /// <param name="candidate">Potential prime number</param>
        /// <returns>true if prime</returns>
        public static bool IsPrime(this long candidate)
        {
            return CheckForPrimeness(candidate);
        }

        private static bool CheckForPrimeness(long candidate)
        {
            if (candidate == 2)
                return true;

            var squareRoot = Math.Sqrt(candidate);
            for (var i = 2; i <= squareRoot; i++)
            {
                if ((candidate % i) == 0)
                    return false;
            }

            return true;
        }

    }
}
