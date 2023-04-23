using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class LCS
    {

        public static int Find(string first, string second)
        {
            Console.WriteLine($"First === {first}");
            Console.WriteLine($"Second === {second}");


            int firstLength = first.Length;
            int secondLength = second.Length;

            int[,] result = new int[firstLength + 1, secondLength + 1];

            for (int i = 0; i <= firstLength; i++)
            {
                for (int j = 0; j <= secondLength; j++)
                {
                    result[i, j] = 0;
                }
            }

            for (int i = 0; i < firstLength; i++)
            {
                for (int j = 0; j < secondLength; j++)
                {
                    if (first[i] == second[j])
                    {
                        result[i+1, j+1] = result[i, j] + 1;
                    }
                    else
                    {
                        result[i+1, j+1] = Math.Max(result[i + 1, j], result[i, j + 1]);
                    }
                }
            }

            Console.Write("     ");
            for (int i = 0; i < secondLength; i++)
            {
                Console.Write(second[i] + "    ");

            }
            Console.WriteLine();


            for (int i = 0; i < firstLength; i++)
            {
                Console.Write(first[i] + "    ");
                for (int j = 0; j < secondLength; j++)
                {
                    if(j==0)
                    {
                    }

                    Console.Write(result[i+1, j+ 1] + "    ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();


            Console.WriteLine("result "+Print(result, first, second, firstLength, secondLength));

            return result[firstLength, secondLength];
        }

        public static string Print(int[,] result, string first, string second, int firstPost, int secondPos)
        {
            if (firstPost == 0 | secondPos == 0)
            {
                return "";
            }
            if (first[firstPost - 1] == second[secondPos - 1])
            {
                return Print(result, first, second, firstPost - 1, secondPos - 1) + first[firstPost - 1];
            }
            if (result[firstPost, secondPos - 1] > result[firstPost - 1, secondPos])
            {
                return Print(result, first, second, firstPost, secondPos - 1);
            }
            return Print(result, first, second, firstPost - 1, secondPos);
        }
    }
}
