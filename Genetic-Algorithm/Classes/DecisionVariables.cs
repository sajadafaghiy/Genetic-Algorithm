using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Classes
{
    public class DecisionVariables
    {
        #region Constructor
        public DecisionVariables(double lowerBound = 0, double upperBound = 1, DecisionVariableType type = DecisionVariableType.Real)
        {
            LowerBound = Math.Min(lowerBound, upperBound);
            UpperBound = Math.Max(lowerBound, upperBound); // Upper bound must be greater then lower bound.
            Type = type;
        }
        #endregion

        #region Properties

        public double LowerBound { get; set; }
        public double UpperBound { get; set; }
        public DecisionVariableType Type { get; set; }

        #endregion

        #region Methds

        /// <summary>
        /// Parse imput xhat to integer, real or binary base lower bound and upper bound.
        /// </summary>
        /// <param name="xhat"></param>
        /// <returns></returns>
        public double Parse(double xhat)
        {
            xhat = Math.Min(xhat, 1);
            xhat = Math.Max(xhat, 0);

            switch (Type)
            {
                case DecisionVariableType.Integer:
                    return Math.Min(LowerBound + Math.Floor((UpperBound - LowerBound + 1) * xhat), UpperBound);

                case DecisionVariableType.Real:
                    return LowerBound + (UpperBound - LowerBound) * xhat;

                case DecisionVariableType.Binary:
                    return (xhat < 0.5) ? 0 : 1; // Math.Round(xhat)

                default:
                    return 0;
            }

        }

        #endregion
    }

    public enum DecisionVariableType
    {
        Real,
        Binary,
        Integer
    }
}