using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsGraph
{
    class Graphh
    {
        public List<Vertex> Vertexs = new List<Vertex>();
        public List<Edge> Edges = new List<Edge>();
        public int CountEdges()
        {
            return Edges.Count;
        }
        public void AddVertex(int NumberVertex)
        {
            Vertex vertex = new Vertex(NumberVertex);
            Vertexs.Add(vertex);
        }
        public void RemoveVertex(int NumberVertex)
        {
            Vertexs.Remove(Vertexs[NumberVertex]);
        }
        public void AddEdge(int Start, int End, int weight = 1)
        {
            Edge edge = new Edge(Vertexs[Start - 1], Vertexs[End - 1], weight);
            Edges.Add(edge);
            edge = new Edge(Vertexs[End - 1], Vertexs[Start - 1], weight);
            Edges.Add(edge);
        }
        public int [,] GetMatrix()
        {
            var matrixs = new int[Vertexs.Count, Vertexs.Count];
            foreach (var edge in Edges)
            {
                var row = edge.VertexStart.NumberVertex - 1;
                var column = edge.VertexEnd.NumberVertex - 1;
                matrixs[row, column] = edge.Weight;
            }
            for (int i = 0; i < matrixs.GetLength(0); i++)
            {
                for (int j = 0; j < matrixs.GetLength(1); j++)
                {
                    if (matrixs[i, j] == 0)
                        matrixs[i, j] = -1;
                }
                matrixs[i, i] = 0;
            }
            return matrixs;
        }
    }
}
