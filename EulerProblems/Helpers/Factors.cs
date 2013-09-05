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

        public static IEnumerable<int> GetUniqueFactorsUpNumber(int number)
        {
            var allfactors = Enumerable.Range(2, number-1).ToList();
            var uniquefactors = Enumerable.Range(2, number-1).ToList();


            foreach (int x in allfactors)
            { 
                for (int i = 0; i <= uniquefactors.Count-1;i++ )
                {
                    int y = uniquefactors[i];
                    if ((y != x) && (y % x == 0))
                    {
                        uniquefactors.Remove(y);
                        i--;
                    }
                }
            }
            return uniquefactors;
        }


    }
}
