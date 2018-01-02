using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Classes
{
    public class OptimizationProblem
    {
        #region Constructor
        public OptimizationProblem(Func<double[], double> costFunction, OptimizationProblemType type = OptimizationProblemType.Minimization)
        {
            CostFunction = costFunction;
            Type = type;
        }
        #endregion

        #region Properties

        private Func<double[], double> CostFunction { get; set; }
        public OptimizationProblemType Type { get; set; }
        private Dictionary<string, DecisionVariables> Variables = new Dictionary<string, DecisionVariables>();
        public double WorstObjeciveValue
        {
            get
            {
                switch (Type)
                {
                    case OptimizationProblemType.Minimization:
                        return double.PositiveInfinity;

                    case OptimizationProblemType.Maximization:
                        return double.NegativeInfinity;

                    default:
                        return double.NaN;
                }
            }
        }

        #endregion

        #region Methods

        public void AddVariable(string name)
        {
            Variables.Add(name, new DecisionVariables { LowerBound = 0, UpperBound = 1 });
        }

        public void AddVariable(string name, double lowerBound, double upperBound, DecisionVariableType type = DecisionVariableType.Real)
        {
            // Binary type should be betwenn 0, 1
            Variables.Add(name, new DecisionVariables { LowerBound = lowerBound, UpperBound = upperBound, Type = type });
        }

        public void DeleteVariable(string name)
        {
            Variables.Remove(name);
        }

        public void ClearVariables()
        {
            Variables.Clear();
        }

        public DecisionVariables SelectVariable(string name)
        {
            return Variables[name];
        }

        public double VariableLowerBound(string name)
        {
            return Variables[name].LowerBound;
        }

        public double VariableUpperBound(string name)
        {
            return Variables[name].LowerBound;
        }

        public int VariablesCount()
        {
            return Variables.Count;
        }

        public double[] Parse(double[] xhat)
        {
            double[] x = new double[Variables.Count];
            int i = 0;
            foreach (var item in Variables)
            {
                x[i] = item.Value.Parse(xhat[i]);
                i++;
            }
            return x;
        }

        public bool IsBetter(double objectiveValue1, double objectiveValue2) => Type == OptimizationProblemType.Minimization ? (objectiveValue1 <= objectiveValue2) : (objectiveValue1 >= objectiveValue2);

        public double Evaluate(double[] x)
        {
            return CostFunction(x);
        }

        public double ParseAndEvaluate(double[] xhat)
        {
            return CostFunction(Parse(xhat));
        }

        #endregion
    }

    public enum OptimizationProblemType
    {
        Minimization, Maximization
    }
}