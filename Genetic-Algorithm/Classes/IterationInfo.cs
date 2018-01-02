using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Classes
{
    public struct IterationInfo
    {
        public int Iteration;
        public double BestObjectiveValue;
    }

    public delegate void AlgorithmStartHandler(object sender);
    public delegate void AlgorithmIterationHandler(object sender, IterationInfo e);
    public delegate void AlgorithmEndHandler(object sender);
}
