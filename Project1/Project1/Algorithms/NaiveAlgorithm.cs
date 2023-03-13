using Project1.Utilities.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Algorithms
{
    internal class NaiveAlgorithm : Algorithm
    {
        public Result Run(string text, string pattern)
        {
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                bool doPatternFit = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        doPatternFit = false;
                        break;
                    }
                }

                if (doPatternFit)
                {
                    Console.WriteLine($"found at index {i}");
                }
            }
            return new Result(1, 1, 1);
        }
    }
}
