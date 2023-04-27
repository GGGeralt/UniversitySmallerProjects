using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class Algorithmer
    {
        List<string> points;

        public int[,] distanceArray;
        public string[,] shortestPathArray;

        public Algorithmer(List<string> points, int[,] distances)
        {
            this.points = points;
            distanceArray = distances;
            shortestPathArray = new string[points.Count, points.Count];
        }

        public void Run()
        {
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points.Count; j++)
                {
                    shortestPathArray[i, j] = points[i];
                }
            }

            for (int i = 0; i < points.Count; i++)
            {
                shortestPathArray[i, i] = " ";
            }

            for (int k = 0; k < points.Count; k++)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    for (int j = 0; j < points.Count; j++)
                    {
                        if (distanceArray[i,k] == int.MaxValue || distanceArray[k,j] == int.MaxValue)
                        {
                            continue;
                        }
                        if (distanceArray[i,j] > distanceArray[i,k] + distanceArray[k, j])
                        {
                            distanceArray[i, j] = distanceArray[i, k] + distanceArray[k, j];
                            shortestPathArray[i, j] = shortestPathArray[k, j];
                        }
                    }
                }
            }
               
        }

        public void PrintState()
        {
            Console.WriteLine();
            Console.Write("  ");

            for (int i = 0; i < points.Count; i++)
            {
                Console.Write($"{points[i]}     ");
            }

            Console.WriteLine();

            for (int i = 0; i < points.Count; i++)
            {
                Console.Write($"{points[i]}|");
                for (int j = 0; j < points.Count; j++)
                {
                    if (distanceArray[i,j] == int.MaxValue)
                    {
                        Console.Write($"MAX   ");
                        
                    }
                    else
                    {
                        Console.Write($"{distanceArray[i, j]}/{shortestPathArray[i, j]}   ");

                    }
                }
                Console.WriteLine();
            }
        }

        public string PrintPath(string first, string second)
        {
            string path = string.Empty;

            if (shortestPathArray[points.IndexOf(first), points.IndexOf(second)] == null) 
            {
                return string.Empty;
            }
            path += second;
            while (first != second)
            {
                second = shortestPathArray[points.IndexOf(first), points.IndexOf(second)];
                path += second;
            }

            string truePath = string.Empty;
            for (int i = 1; i <= path.Length; i++)
            {
                truePath += $"{path[path.Length - i]}";

                if (i != path.Length)
                {
                    truePath += "->";
                }
            }
            return truePath;
        }
    }
}
