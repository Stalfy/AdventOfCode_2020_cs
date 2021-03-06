using System.Collections.Generic;

namespace AdventOfCode.Solvers
{
  public interface Solver
  {
     public string SolvePartA(IEnumerable<string> input);
     public string SolvePartB(IEnumerable<string> input);
  }
}
