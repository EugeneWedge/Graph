using System;

namespace UnitTestsGraph
{
    class ABellmanFord
    {
        public static int[] BellmanFord(int[,] graph, int V,
                                int E, int src)
        {
            int[] dis = new int[V];
            for (int i = 0; i < V; i++)
                dis[i] = int.MaxValue;

            dis[src] = 0;

            for (int i = 0; i < V - 1; i++)
            {
                for (int j = 0; j < E; j++)
                {
                    if (dis[graph[j, 0]] != int.MaxValue && dis[graph[j, 0]] + graph[j, 2] <
                        dis[graph[j, 1]])
                        dis[graph[j, 1]] =
                        dis[graph[j, 0]] + graph[j, 2];
                }
            }

            for (int i = 0; i < E; i++)
            {
                int x = graph[i, 0];
                int y = graph[i, 1];
                int weight = graph[i, 2];
                if (dis[x] != int.MaxValue &&
                        dis[x] + weight < dis[y])
                    Console.WriteLine("Graph contains negative" +
                                                " weight cycle");
            }

            Console.WriteLine(String.Format("Вершина\t\t Відстань від істочника\n"));
            for (int i = 0; i < V; i++)
            {
                if(dis[i] != int.MaxValue)
                    Console.WriteLine(String.Format($"{i+1} \t\t\t  {dis[i]}\n"));
                else
                    Console.WriteLine( String.Format($"{i + 1} \t\t\t  INF\n"));
            }
            return dis;
        }
    }
}