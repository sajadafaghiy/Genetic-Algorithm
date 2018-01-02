using System;

namespace GeneticAlgorithm.Classes
{
    public class Randoms
    {
        static Random random = new Random();

        /// <summary>
        /// Random of integer type.
        /// </summary>
        /// <returns></returns>
        public static int RandInt() => random.Next();

        /// <summary>
        /// Random of double type.
        /// </summary>
        /// <returns></returns>
        public static double Rand() => random.NextDouble();

        /// <summary>
        /// Uniform distribution of integer type between 0 and x. 
        /// </summary>
        /// <param name="x">The 1st number.</param>
        /// <returns></returns>
        public static int Rand(int x) => random.Next(0, x - 1);

        /// <summary>
        /// Uniform distribution of integer type between a and b. 
        /// </summary>
        /// <param name="a">The 1st number.</param>
        /// <param name="b">The 2nd number.</param>
        /// <returns></returns>
        public static int Rand(int a, int b) => random.Next(a, b);

        /// <summary>
        /// Uniform distribution between a and b. 
        /// </summary>
        /// <param name="a">The 1st number.</param>
        /// <param name="b">The 2nd number.</param>
        /// <returns></returns>
        public static double Rand(double a, double b) => a + (b - a) * Rand();

        /// <summary>
        /// Vector between a and b. 
        /// </summary>
        /// <param name="a">The 1st number.</param>
        /// <param name="b">The 2nd number.</param>
        /// <param name="n">Number of values.</param>
        /// <returns></returns>
        public static double[] Rand(double a, double b, int n)
        {
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = Rand(a, b);
            }
            return x;
        }

        public static double NormalRand(double sigma = 1) => sigma * Math.Sqrt(-2 * Math.Log(Rand())) * Math.Cos(2 * Math.PI * Rand());
    }
}
