using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Algorithms
{
    class AFloydWarshal
    {
       static int INF = 99999;
        public static int[,] FloydWarshall(int[,] Matrix)
        {
            // Матрица минимального расстояния до каждой вершины
            int[,] distance = new int[Matrix.GetLength(0), Matrix.GetLength(0)];

            for (int i = 0; i < Matrix.GetLength(0); ++i)
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                    distance[i, j] = Matrix[i, j];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if(distance[i,j] == -1)
                    distance[i, j] = INF;
                }
                distance[i, i] = 0;
            }

            for (int k = 0; k < Matrix.GetLength(0); ++k)
            {
                for (int i = 0; i < Matrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < Matrix.GetLength(0); ++j)
                    {
                        if (distance[i, k] + distance[k, j] < distance[i, j])
                        {
                            distance[i, j] = distance[i, k] + distance[k, j];
                        }
                    }
                }
            }
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (distance[i, j] == INF)
                        distance[i, j] = -1;
                }
                distance[i, i] = 0;
            }
            return distance;
        }
    }
}
