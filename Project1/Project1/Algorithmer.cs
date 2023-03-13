using Project1.Algorithms;
using Project1.Utilities.DataTypes;
using Project1.Utilities.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Algorithmer
    {
        static TextGenerator generator = new TextGenerator();

        public static void Run()
        {
            RunAlgorithm(new NaiveAlgorithm());
        }

        private static void RunAlgorithm(Algorithm algorithm)
        {
            string pattern = "ABA";

            int from = 6;
            int to = 7;

            //double[] computationalComplexity = new double[to - from];
            //double[] memoryComplexity = new double[to - from];
            //double[] indexes = new double[to - from];

            int index = 0;

            for (int i = from; i < to; i++)
            {
                string text = "AAAAABA";
                Console.WriteLine(text);

                Result result = algorithm.Run(text, pattern);

                //computationalComplexity[index] = result.GetComputationalComplexity();
                //memoryComplexity[index] = result.GetMemoryComplexity();
                //indexes[index] = index;
                index++;
            }


            //var computationalComplexityGraph = new ScottPlot.Plot(400, 300);
            //computationalComplexityGraph.AddScatter(indexes, computationalComplexity);
            //computationalComplexityGraph.SaveFig("computationalComplexity.png");

            //var memoryComplexityGraph = new ScottPlot.Plot(400, 300);
            //memoryComplexityGraph.AddScatter(indexes, memoryComplexity);
            //memoryComplexityGraph.SaveFig("memoryComplexity.png");
        }
    }
}
