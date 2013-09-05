using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public class Problem5 : IProblem 
    {
        #region IProblem Members


        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        public string Solve()
        {
           //to make it efficient lets get the unique factors of 20 (if its divisible by 2 we dont' need to test for multiples of 2 etc...
          //then count from 10 onwards till we find a number thats divisible by all unique factors..

            bool foundMatch = false;
            int  answer = 0;
            int number  = 10;

            //problem here with my lowest common multiple algorithm..
            //List<int> uniqueNumbers = Factors.GetUniqueFactorsUpToANumber(20).ToList();
            
            
            //slow brute force way .. works
            List<int> uniqueNumbers = Enumerable.Range(2,19).ToList();

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
            return number.ToString();
        }

        #endregion
    }
}
