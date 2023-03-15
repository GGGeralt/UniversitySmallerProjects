using Project1.Utilities.DataTypes;
using ScottPlot.Drawing.Colormaps;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Algorithms
{
    internal class SundayAlgorithm : Algorithm
    {
        public Result Run(string text, string pattern)
        {
            Result result = new Result();

            int[] lastp = new int[26];

            for (int i = 0; i < 26; i++)
            {
                lastp[i] = -1;
            }
            for (int i = 0; i < pattern.Length; i++)
            {
                lastp[pattern[i] - 65] = i;
            }

            int index = 0;
            while (index <= text.Length - pattern.Length)
            {
                if (MatchesAt(text, index, pattern, result))
                {
                    result.indexes.Add(index);
                }

                index += pattern.Length;

                if (index < text.Length)
                {
                    index -= lastp[(int)text[index] - 65];
                }
            }

            return result;
        }

        public bool MatchesAt(string text, int index, string pattern, Result result)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                result.computationalComplexity++;
                if (pattern[i] != text[index + i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
