using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class GraphNode
    {
        public int val;
        public IList<GraphNode> neighbors;

        public GraphNode()
        {
            val = 0;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int val)
        {
            this.val = val;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int val, List<GraphNode> neighbors)
        {
            this.val = val;
            this.neighbors = neighbors;
        }
    }
}
