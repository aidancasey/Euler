using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{

    public class Problem1
    {

        public static void Solve()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000
            Stopwatch timer = Stopwatch.StartNew();

            int sum = 0;
            for (int i = 0; i<1000; i++)
            {

                //if ((i % 3 ==0 ) || (i % 5==0) || (i % 6==0) || (i % 9==0))
                //{
                //    sum += i;
                //}

                // but 6 and 9 are divisible by 3 so we can remove them from the if block
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }

            }
            timer.Stop();

            Console.WriteLine(sum.ToString());
            Console.WriteLine("time taken  " + timer.ElapsedTicks + "ticks ");

        }


        //super nerdy way
        //see http://www.mathblog.dk/project-euler-problem-1/
        public static void SolveNerdyWay()
        {
            Stopwatch timer = Stopwatch.StartNew();  
            var result = SumDivisbleBy(3,999)+SumDivisbleBy(5,999)-SumDivisbleBy(15,999);
            timer.Stop();

            Console.WriteLine(result.ToString());
            Console.WriteLine("time taken  " + timer.ElapsedTicks + "ticks ");

        }
 
        
        private static int SumDivisbleBy(int n, int p)
        {
            return n * (p / n) * ((p / n) + 1) / 2;
        }


    }
}
