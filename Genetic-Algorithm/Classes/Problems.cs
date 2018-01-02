using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Classes
{
    public static class Problems
    {
        /// <summary>
        /// Sphere - cost function
        /// </summary>
        /// <param name="num">Array of numbers.</param>
        /// <returns>Sigma(x^2)</returns>
        public static double Sphere(double[] num) => num.Sum(x => Math.Pow(x, 2));
        /// <summary>
        /// Sphere - cost function
        /// </summary>
        /// <param name="num">Array of numbers.</param>
        /// <returns>Sigma(x^2) = A fixed number</returns>
        public static double Function(double[] x) => Math.Abs(x.Select(a => a * a).Sum() - Math.Pow(12, 2));
    }
}
