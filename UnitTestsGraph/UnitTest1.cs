using System;
using Xunit;

namespace UnitTestsGraph
{
    public class UnitTestGraph
    {
        [Fact]
        public void Test1AddVertex()
        {
            //arange
            Graphh graphh = new Graphh();
           int expected = 4;
            //act
            graphh.AddVertex(1);
            graphh.AddVertex(2);
            graphh.AddVertex(3);
            graphh.AddVertex(4);
            int actual = graphh.Vertexs.Count;
            //assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Test1AddEdge()
        {
            //arange
            Graphh graphh = new Graphh();
            int expected = 8;
            //act
            graphh.AddVertex(1);
            graphh.AddVertex(2);
            graphh.AddVertex(3);
            graphh.AddVertex(4);
            graphh.AddEdge(1, 2);
            graphh.AddEdge(2, 3);
            graphh.AddEdge(1, 3);
            graphh.AddEdge(1, 4);
            int actual = graphh.Edges.Count;
            //assert
            Assert.Equal(expected, actual);

        }
    }
    public class UnitTestAlgorithms
    {
        [Fact]
        public void Test1AFloydWarshal()
        {
            //arange
            Graphh graphh = new Graphh();
            int [,] expected = new int[4, 4] { {0,1,4,3 },{ 1, 0, 3, 4 },{ 4, 3, 0, 2 },{ 3, 4, 2, 0 } };
            //act
            graphh.AddVertex(1);
            graphh.AddVertex(2);
            graphh.AddVertex(3);
            graphh.AddVertex(4);
            graphh.AddEdge(1, 2,1);
            graphh.AddEdge(2, 3,3);
            graphh.AddEdge(1, 3,8);
            graphh.AddEdge(1, 4,3);
            graphh.AddEdge(3, 4, 2);
            int[,] MatrixGraph = graphh.GetMatrix();
            int[,] actualMatrixGraph = AFloydWarshal.FloydWarshall(MatrixGraph);
            //assert
            for (int i = 0; i < actualMatrixGraph.GetLength(0); i++)
            {
                for (int j = 0; j < actualMatrixGraph.GetLength(1); j++)
                {
                 Assert.Equal(expected[i,j], actualMatrixGraph[i,j]);
                }
            }
        }
        [Fact]
        public void TestAFrodBellman()
        {
            //arange
            Graphh graphh = new Graphh();
            int[,] expected = new int[4, 4] { { 0, 1, 4, 3 }, { 1, 0, 3, 4 }, { 4, 3, 0, 2 }, { 3, 4, 2, 0 } };
            //act
            graphh.AddVertex(1);
            graphh.AddVertex(2);
            graphh.AddVertex(3);
            graphh.AddVertex(4);
            graphh.AddEdge(1, 2, 1);
            graphh.AddEdge(2, 3, 3);
            graphh.AddEdge(1, 3, 8);
            graphh.AddEdge(1, 4, 3);
            graphh.AddEdge(3, 4, 2);
            int[,] MatrixGraph = graphh.GetMatrix();
            int[] actualMatrixGraph = ABellmanFord.BellmanFord(MatrixGraph, graphh.Vertexs.Count, graphh.Edges.Count, 1);
            //assert
            for (int i = 0; i < actualMatrixGraph.GetLength(0); i++)
            {
                for (int j = 0; j < actualMatrixGraph.GetLength(1); j++)
                {
                    Assert.Equal(expected[i, j], actualMatrixGraph[i]);
                }
            }
        }
            [Fact]
        public void TestADijekstra()
        {
            //arange
            Graphh graphh = new Graphh();
            int[,] expected = new int[4, 4] { { 0, 1, 4, 3 }, { 1, 0, 3, 4 }, { 4, 3, 0, 2 }, { 3, 4, 2, 0 } };
            //act
            graphh.AddVertex(1);
            graphh.AddVertex(2);
            graphh.AddVertex(3);
            graphh.AddVertex(4);
            graphh.AddEdge(1, 2, 1);
            graphh.AddEdge(2, 3, 3);
            graphh.AddEdge(1, 3, 8);
            graphh.AddEdge(1, 4, 3);
            graphh.AddEdge(3, 4, 2);
            int[,] MatrixGraph = graphh.GetMatrix();
            int[] actualMatrixGraph = ADijkstra.dijkstra(MatrixGraph,0);
            //assert
            for (int i = 0; i < actualMatrixGraph.GetLength(0); i++)
            {
                for (int j = 0; j < actualMatrixGraph.GetLength(1); j++)
                {
                    Assert.Equal(expected[i, j], actualMatrixGraph[i]);
                }
            }
        }
    }
}
