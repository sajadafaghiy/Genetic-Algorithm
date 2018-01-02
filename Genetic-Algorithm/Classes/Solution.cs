using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Classes
{
    public struct Solution
    {
        public double[] Position;
        public double[] ActualPosition;
        public double ObjectiveValue;

        public void EvaluateIn(OptimizationProblem problem)
        {
            ActualPosition = problem.Parse(Position);
            ObjectiveValue = problem.Evaluate(ActualPosition);
        }
    }
}
