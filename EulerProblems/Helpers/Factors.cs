using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public static class Factors
    {
        public static IEnumerable<long> GetFactors(long number)
        {
            var factors = new List<long> { 1, number };
            long factor = 2;
            var end = number;

            while (factor <= end)
            {
                if (number % factor == 0)
                {
                    end = number / factor;

                    if (!factors.Contains(factor))
                    {
                        factors.Add(factor);
                    }

                    if (!factors.Contains(end))
                    {
                        factors.Add(end);
                    }                   
                }
                factor++;
            }
            return factors;
        }

    }
}
