using System;
using System.Collections.Generic;
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

            var problem = new EulerProblems.Problem2();
            problem.Solution_First_Attempt();

            problem.Soluion_More_Readable();
            
            Console.ReadLine();
        }
    }
}
