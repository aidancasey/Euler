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
            Stopwatch timer;
            string result;
            do
            {
                userInput = Console.ReadLine();
                if (userInput != null)
                {
                    var t = Type.GetType(string.Format("EulerProblems.Problem{0}, EulerProblems", userInput), false, true);


                        var problem = Activator.CreateInstance(t) as IProblem;

                        Console.WriteLine("running Solve()");
                        timer = Stopwatch.StartNew();
                        result = problem.Solve();
                        Console.WriteLine("Answer --> " + result);
                        timer.Stop();
                        Console.WriteLine("time taken  " + timer.ElapsedMilliseconds + " (ms)");
                        timer.Reset();


                
                if ((t.GetInterfaces().Contains(typeof(ISolveProblemManyWays))))
                {
                    var extenededProblemSolver = Activator.CreateInstance(t) as ISolveProblemManyWays;

                    Console.WriteLine("running LinqSolve()");
                     timer = Stopwatch.StartNew();
                     result = extenededProblemSolver.LinqSolve();
                    Console.WriteLine("Answer --> " + result);
                    timer.Stop();
                    Console.WriteLine("time taken  " + timer.ElapsedMilliseconds + " (ms)");
                    timer.Reset();


                    Console.WriteLine("running AlgebraSolve()");
                    timer = Stopwatch.StartNew();
                    result = extenededProblemSolver.AlgebraSolve();
                    Console.WriteLine("Answer --> " + result);
                    timer.Stop();
                    Console.WriteLine("time taken  " + timer.ElapsedMilliseconds + " (ms)");
                    timer.Reset();
                }
                
       
                }

            } while (userInput != null);
            
            Console.ReadLine();
        }


    }
}
