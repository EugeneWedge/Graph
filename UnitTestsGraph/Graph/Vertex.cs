using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsGraph
{
    // Класс вершины
    class Vertex
    {
        public Vertex (int NumberVertex)
        {
            this.NumberVertex = NumberVertex;
        }
        /// <summary>
        /// Номер вершины
        /// </summary>
       public int NumberVertex { get; set; }
    }
}
