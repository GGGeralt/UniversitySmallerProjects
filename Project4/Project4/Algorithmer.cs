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

        public Algorithmer(List<string> points, int[,] distances)
        {
            this.points = points;
            distanceArray = distances;
        }


        /*
         * for (int i = 0; i < distances.length; i++) {
            for (int j = 0; j < distances.length; j++) {
                for (int k = 0; k < distances.length; k++) {
                    if ((distances[j][i] == MAX) || (distances[i][k] == MAX)) {
                        continue;
                    }
                    distances[j][k] = Math.min(distances[j][j], distances[j][k] + distances[k][j]);
                }
            }
        }
        */
        public void Run()
        {
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points.Count; j++)
                {
                    for (int k = 0; k < points.Count; k++)
                    {
                        if (distanceArray[i, k] == int.MaxValue || distanceArray[k,j]==int.MaxValue)
                        {
                            continue;
                        }
                        distanceArray[i,j] = Math.Min(distanceArray[i, j], distanceArray[i,k] + distanceArray[k,j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void PrintState()
        {
            Console.WriteLine();
            Console.Write("  ");

            for (int i = 0; i < points.Count; i++)
            {
                Console.Write($"{points[i]}   ");
            }

            Console.WriteLine();

            for (int i = 0; i < points.Count; i++)
            {
                Console.Write($"{points[i]}|");
                for (int j = 0; j < points.Count; j++)
                {
                    if (distanceArray[i,j] == int.MaxValue)
                    {
                        Console.Write($"MAX ");
                        
                    }
                    else
                    {
                        Console.Write($"{distanceArray[i, j]}   ");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
