using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsDijkstra
{
    public class Vertex
    {
        public string label;
        public bool isInTree;

        public Vertex(string lab)
        {
            label = lab;
            isInTree = false;
        }
    }
}
