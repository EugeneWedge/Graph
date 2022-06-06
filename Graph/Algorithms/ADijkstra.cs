using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph.Algorithms
{
    class ADijkstra
    {
        private static readonly int NO_PARENT = -1;

        public static void dijkstra(int[,] adjacencyMatrix,
                                            int startVertex,
                                            RichTextBox richTextBox)
        {
            int nVertices = adjacencyMatrix.GetLength(0);

            int[] shortestDistances = new int[nVertices];

            bool[] added = new bool[nVertices];

            for (int vertexIndex = 0; vertexIndex < nVertices;
                                                vertexIndex++)
            {
                shortestDistances[vertexIndex] = int.MaxValue;
                added[vertexIndex] = false;
            }

            shortestDistances[startVertex] = 0;

            int[] parents = new int[nVertices];


            parents[startVertex] = NO_PARENT;


            for (int i = 1; i < nVertices; i++)
            {

                int nearestVertex = -1;
                int shortestDistance = int.MaxValue;
                for (int vertexIndex = 0;
                        vertexIndex < nVertices;
                        vertexIndex++)
                {
                    if (!added[vertexIndex] &&
                        shortestDistances[vertexIndex] <
                        shortestDistance)
                    {
                        nearestVertex = vertexIndex;
                        shortestDistance = shortestDistances[vertexIndex];
                    }
                }

                added[nearestVertex] = true;

                for (int vertexIndex = 0;
                        vertexIndex < nVertices;
                        vertexIndex++)
                {
                    int edgeDistance = adjacencyMatrix[nearestVertex, vertexIndex];

                    if (edgeDistance > 0
                        && ((shortestDistance + edgeDistance) <
                            shortestDistances[vertexIndex]))
                    {
                        parents[vertexIndex] = nearestVertex;
                        shortestDistances[vertexIndex] = shortestDistance +
                                                        edgeDistance;
                    }
                }
            }

            printSolution(startVertex, shortestDistances, parents, richTextBox);
        }

        private static void printSolution(int startVertex,
                                        int[] distances,
                                        int[] parents,
                                        RichTextBox richTextBox)
        {
            int nVertices = distances.Length;
            richTextBox.Text += ("Вершина\t\t Дистанція\tШлях");

            for (int vertexIndex = 0;
                    vertexIndex < nVertices;
                    vertexIndex++)
            {
                if (vertexIndex != startVertex)
                {
                    richTextBox.Text += String.Format($"\n {startVertex + 1} ->");
                    richTextBox.Text += String.Format($"{vertexIndex+1}\t\t");
                    if (distances[vertexIndex] != int.MaxValue)
                    richTextBox.Text += String.Format($"{distances[vertexIndex]}\t\t");
                    else
                    richTextBox.Text += String.Format($"INF\t\t");
                    printPath(vertexIndex, parents, richTextBox);
                }
            }
        }

        private static void printPath(int currentVertex,
                                    int[] parents,
                                    RichTextBox richTextBox)
        {

            if (currentVertex == NO_PARENT)
            {
                return;
            }
            printPath(parents[currentVertex], parents, richTextBox);
            richTextBox.Text += String.Format($"{currentVertex+1}  ");
        }
    }
}