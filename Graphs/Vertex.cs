using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Vertex
    {
        public bool wasVisited;
        public string label;

        public Vertex(string label)
        {
            this.label = label;
            wasVisited = false;
        }
    }
}
