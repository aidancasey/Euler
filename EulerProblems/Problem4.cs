using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerProblems.Helpers;
using System.Linq;

namespace EulerProblems
{
    public class Problem4 : IProblem
    {
        #region IProblem Members

        /*
        // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.
         */

        public string Solve()
        {
           // get all pallindromes less than 1000 * 1000 in size
            List<int> pallindromeNums = Pallindromes.GetPalindromeNumbers(6).OrderByDescending(x => x).ToList();
                      
            int result = 0;

            // for each one check if a numers between 100->1000  divide in evenly
            foreach (int number in pallindromeNums)
            {
                for (int i = 1000; i >= 100; i--)
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
        #endregion
    }
}
