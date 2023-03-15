using Project1.Algorithms;
using Project1.Utilities.DataTypes;
using Project1.Utilities.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum AlgorithmName
{
    Naive,
    Sunday,
}
namespace Project1
{
    internal class Algorithmer
    {
        static TextGenerator generator = new TextGenerator();

        public static void Run(AlgorithmName algorithm)
        {
            switch (algorithm)
            {
                case AlgorithmName.Naive:
                    RunAlgorithm(new NaiveAlgorithm(), "Naive");
                    break;
                case AlgorithmName.Sunday:
                    RunAlgorithm(new SundayAlgorithm(), "Sunday");
                    break;
                default:
                    break;
            }
        }

        private static void RunAlgorithm(Algorithm algorithm, string name)
        {
            int index;

            int minTextSize = 1;
            int maxTextSize = 10_000;

            double[] textSizeComplexity = new double[maxTextSize - minTextSize];
            double[] textSizeIndexes = new double[maxTextSize - minTextSize];

            index = 0;
            for (int i = minTextSize; i < maxTextSize; i++)
            {
                string text = generator.GenerateFromAplhabet(i);
                string pattern = generator.GenerateFromAplhabet(5);

                Result result = algorithm.Run(text, pattern);
                textSizeComplexity[index] = result.computationalComplexity;
                textSizeIndexes[index] = index;
                index++;
            }
            var textSizeGraph = new ScottPlot.Plot(400, 300);
            textSizeGraph.AddScatter(textSizeIndexes, textSizeComplexity);
            textSizeGraph.SaveFig(name + "_Text_Size_Complexity.png");



            int minPatternSize = 1;
            int maxPatternSize = 100;

            double[] patternSizeComplexity = new double[maxPatternSize - minPatternSize];
            double[] paternSizeIndexes = new double[maxPatternSize - minPatternSize];

            index = 0;
            for (int i = minPatternSize; i < maxPatternSize; i++)
            {
                string text = generator.GenerateFromAplhabet(100_000);
                string pattern = generator.GenerateFromAplhabet(i);

                Result result = algorithm.Run(text, pattern);
                patternSizeComplexity[index] = result.computationalComplexity;
                paternSizeIndexes[index] = index;
                index++;
            }
            var patternSizeGraph = new ScottPlot.Plot(400, 300);
            patternSizeGraph.AddScatter(paternSizeIndexes, patternSizeComplexity);
            patternSizeGraph.SaveFig(name + "_Pattern_Size_Complexity.png");



            int minAlphabetSize = 0;
            int maxAlphabetSize = 26;

            double[] alphabetSizeComplexity = new double[maxAlphabetSize - minAlphabetSize];
            double[] alphabetSizeIndexes = new double[maxAlphabetSize - minAlphabetSize];

            index = 0;
            for (int i = minAlphabetSize; i < maxAlphabetSize; i++)
            {
                string text = generator.GenerateFromTo('A', (char)('A' + i), 100_000);
                string pattern = generator.GenerateFromTo('A', (char)('A' + i), 10);

                Result result = algorithm.Run(text, pattern);
                alphabetSizeComplexity[index] = result.computationalComplexity;
                alphabetSizeIndexes[index] = index;
                index++;
            }
            var alphabetSizeGraph = new ScottPlot.Plot(400, 300);
            alphabetSizeGraph.AddScatter(alphabetSizeIndexes, alphabetSizeComplexity);
            alphabetSizeGraph.SaveFig(name + "_Alphabet_Size_Complexity.png");


        }
    }
}
