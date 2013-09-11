namespace EulerProblems
{
    public interface IProblem
    {
        string Solve();
    }

    public interface ISolveProblemManyWays : IProblem
    {
        string LinqSolve();
        string AlgebraSolve();

    }
}
