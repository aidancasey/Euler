using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EulerProblems;

namespace ProblemSolver
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the problem number to solver (press CTRL+Z to exit):");
            Console.WriteLine();
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                if (userInput != null)
                {
                    var t = Type.GetType(string.Format("EulerProblems.Problem{0}, EulerProblems", userInput), false, true);
                    var problem = Activator.CreateInstance(t) as IProblem;

                    Stopwatch timer = Stopwatch.StartNew();
                    string result = problem.Solve();
                    Console.WriteLine("Answer --> " + result);

                    timer.Stop();
                    Console.WriteLine("time taken  " + timer.ElapsedMilliseconds + " (ms)");           
                }

            } while (userInput != null);
            
            Console.ReadLine();
        }


    }
}
