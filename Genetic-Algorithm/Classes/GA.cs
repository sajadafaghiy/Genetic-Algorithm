using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Classes
{
    /// <summary>
    /// Genetic Algorithm.
    /// </summary>
    public class GA
    {
        #region Constructor
        public GA(int population = 100, int iterations = 100)
        {
            Population = population;
            Iterations = iterations;
        }
        #endregion

        #region Properties

        public int Population { get; set; }
        public int Iterations { get; set; }
        public double CrossoverValue { get; set; }
        public double MutationValue { get; set; }
        public Solution BestSolution;

        #endregion

        #region Events

        public event AlgorithmStartHandler OnStart;
        public event AlgorithmIterationHandler OnIteration;
        public event AlgorithmEndHandler OnEnd;

        #endregion

        #region Methods

        /// <summary>
        /// Set crossover and mutation value of genetic algorithm.
        /// </summary>
        /// <param name="data">Is a tupple that contain crossover and mutation value as double.</param>
        public void SetData((double crossover, double mutation) data)
        {
            CrossoverValue = data.crossover;
            MutationValue = data.mutation;
        }

        public void Run(OptimizationProblem problem)
        {
            OnStart?.Invoke(this);

            // Initialization of Population
            Solution[] population = new Solution[Population];
            for (int i = 0; i < Population; i++)
            {
                population[i].Position = Randoms.Rand(0, 1, problem.VariablesCount());
                population[i].EvaluateIn(problem);
            }

            // Sort Population
            if (problem.Type == OptimizationProblemType.Minimization)
            {
                //population = (from p in population
                //       orderby p.ObjectiveValue ascending
                //       select p).ToArray();

                population = population.OrderBy(x => x.ObjectiveValue).ToArray();
            }
            else
            {
                //population = (from p in population
                //              orderby p.ObjectiveValue descending
                //       select p).ToArray();

                population = population.OrderByDescending(x => x.ObjectiveValue).ToArray();
            }

            // Update Best Solution
            BestSolution.Position = (double[])population[0].Position.Clone();
            BestSolution.ActualPosition = (double[])population[0].ActualPosition.Clone();
            BestSolution.ObjectiveValue = population[0].ObjectiveValue;

            // Main Loop
            int crossover = (int)Math.Round((CrossoverValue * Population) / 2);
            int mutation = (int)Math.Round(MutationValue * Population);

            for (int iter = 0; iter < Iterations; iter++)
            {

                // Crossover
                Solution[] popca = new Solution[crossover];
                Solution[] popcb = new Solution[crossover];
                for (int i = 0; i < crossover; i++)
                {
                    Solution p1 = population[Randoms.Rand(Population)];
                    Solution p2 = population[Randoms.Rand(Population)];

                    Solution[] offsprings = Crossover(p1, p2);
                    popca[i] = offsprings[0];
                    popcb[i] = offsprings[1];

                    popca[i].EvaluateIn(problem);
                    popcb[i].EvaluateIn(problem);
                }

                // Mutation
                Solution[] popm = new Solution[mutation];
                for (int i = 0; i < mutation; i++)
                {
                    Solution parent = population[Randoms.Rand(Population)];
                    popm[i] = Mutation(parent);
                    popm[i].EvaluateIn(problem);
                }

                // Concat Populations
                var newPopulation = population.Concat(popca).Concat(popcb).Concat(popm);

                // Sort Population and Remove Extra Members
                if (problem.Type == OptimizationProblemType.Minimization)
                {
                    //population = (from p in newPopulation
                    //              orderby p.ObjectiveValue ascending
                    //       select p).Take(Population).ToArray();

                    population = newPopulation.OrderBy(x => x.ObjectiveValue).Take(Population).ToArray();
                }
                else
                {
                    //population = (from p in newPopulation
                    //              orderby p.ObjectiveValue descending
                    //       select p).Take(Population).ToArray();

                    population = newPopulation.OrderByDescending(x => x.ObjectiveValue).Take(Population).ToArray();
                }

                // Update Best Solution
                BestSolution.Position = (double[])population[0].Position.Clone();
                BestSolution.ActualPosition = (double[])population[0].ActualPosition.Clone();
                BestSolution.ObjectiveValue = population[0].ObjectiveValue;

                IterationInfo e;
                e.Iteration = iter + 1;
                e.BestObjectiveValue = BestSolution.ObjectiveValue;
                OnIteration?.Invoke(this, new IterationInfo { Iteration = iter + 1, BestObjectiveValue = BestSolution.ObjectiveValue });
            }

            OnEnd?.Invoke(this);
        }

        /// <summary>
        /// Crossover two parent and return two offsprings.
        /// </summary>
        /// <param name="p1">Parent 1</param>
        /// <param name="p2">Parent 2</param>
        /// <returns>Two offsprings.</returns>
        private Solution[] Crossover(Solution p1, Solution p2)
        {
            // Children
            Solution[] offsprings = new Solution[2];

            int n = p1.Position.Length;
            offsprings[0].Position = new double[n];
            offsprings[1].Position = new double[n];

            double gamma = 0.2;

            for (int j = 0; j < n; j++)
            {
                double alpha = Randoms.Rand(-gamma, 1 + gamma);
                offsprings[0].Position[j] = alpha * p1.Position[j] + (1 - alpha) * p2.Position[j];
                offsprings[1].Position[j] = alpha * p2.Position[j] + (1 - alpha) * p1.Position[j];

                offsprings[0].Position[j] = Math.Max(offsprings[0].Position[j], 0);
                offsprings[0].Position[j] = Math.Min(offsprings[0].Position[j], 1);

                offsprings[1].Position[j] = Math.Max(offsprings[1].Position[j], 0);
                offsprings[1].Position[j] = Math.Min(offsprings[1].Position[j], 1);
            }

            return offsprings;
        }

        /// <summary>
        /// Mutation of a member and return mutant of that.
        /// </summary>
        /// <param name="p">A member who wants to mutate.</param>
        /// <returns>A mutant solution.</returns>
        private Solution Mutation(Solution p)
        {
            Solution mutant = new Solution { Position = (double[])p.Position.Clone() };

            double sigma = 0.1;
            for (int j = 0; j < mutant.Position.Length; j++)
            {
                mutant.Position[j] += Randoms.NormalRand(sigma);
                mutant.Position[j] = Math.Max(mutant.Position[j], 0);
                mutant.Position[j] = Math.Min(mutant.Position[j], 1);
            }

            return mutant;
        }

        #endregion
    }
}
