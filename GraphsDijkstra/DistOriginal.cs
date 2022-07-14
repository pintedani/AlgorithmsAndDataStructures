using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsDijkstra
{
    public class DistOriginal
    {
        public int distance;
        public int parentVert;
        public DistOriginal(int pv, int d)
        {
            distance = d;
            parentVert = pv;
        }
    }
}
