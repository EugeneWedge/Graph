using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsGraph
{
    /// <summary>
    /// Класс рёбра
    /// </summary>
    class Edge
    {
        public Edge(Vertex start, Vertex end, int weight = 1)
        {
            VertexStart = start;
            VertexEnd = end;
            Weight = weight;
        }
       public Vertex VertexStart { get; set; }
       public Vertex VertexEnd { get; set; }
       public int Weight { get; set; }
    }
}
