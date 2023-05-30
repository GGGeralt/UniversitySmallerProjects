using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class MSTPrim
    {
        private static int MinKey(int[] key, bool[] set, int verticesCount)
        {
            int min = int.MaxValue, minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (set[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private static void Print(int[] vertices, int[,] graph)
        {
            Console.WriteLine("From --> To [Weight]");
            for (int i = 1; i < graph.GetLength(0); ++i)
            {
                Console.WriteLine($"   {vertices[i]} --> {i} [{graph[i, vertices[i]]}]" );
            }
        }

        public static void Prim(int[,] graph)
        {
            int verticesCount = graph.GetLength(0);

            int[] vertices = new int[verticesCount];
            int[] edgeWeigth = new int[verticesCount];
            bool[] isVertexSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                edgeWeigth[i] = int.MaxValue;
                isVertexSet[i] = false;
            }

            edgeWeigth[0] = 0;
            vertices[0] = -1;

            for (int verticeIndex = 0; verticeIndex < verticesCount - 1; ++verticeIndex)
            {
                int minkey = MinKey(edgeWeigth, isVertexSet, verticesCount);
                isVertexSet[minkey] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (Convert.ToBoolean(graph[minkey, v]) && isVertexSet[v] == false && graph[minkey, v] < edgeWeigth[v])
                    {
                        vertices[v] = minkey;
                        edgeWeigth[v] = graph[minkey, v];
                    }
                }
            }

            Print(vertices, graph);
        }
    }
}
