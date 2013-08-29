using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public class Problem3
    {
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //
        //  What is the largest prime factor of the number 600851475143


        //approach 1 - failed miserable . come up with an array of all the prime numbers less than half the size of the required number
        //them pump them thru and return find the largest ones with a mod 0
        //time to loop was too long

        //approach 2 -after some googling I found out that a prime factor is always less than the square root of a number :)

   

        public void Approach_1_Solve()
        {

            long number = 13195;

            var primeNumbers = GeneratePrimeNmubers(number / 2);

            primeNumbers.Reverse();

            foreach (long i in primeNumbers)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("largest prime factor is " + i.ToString());
                    break;
                }
            }

        }


        public void Solve()
        {

            long number = 600851475143;
         


            for (var j = (Math.Round( Math.Sqrt(number),0) +1);j>=2; j--)
            {
                Console.WriteLine("trying " + j.ToString());

                if (IsPrimeNumber((long)j))
                {
                    Console.WriteLine("testing prime no " + j.ToString());
                    if (number % j == 0)
                    {
                        Console.WriteLine("largest prime factor of " + number + " is " + j.ToString());
                        break;
                    }
                    
                }

            }
        }


        public List<long> GeneratePrimeNmubers(long maxNumber)
        {
            List<long> allPrimeNumbers = new List<long>();

            for (long i = 1; i <= Math.Sqrt(maxNumber); i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine(i.ToString());
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
