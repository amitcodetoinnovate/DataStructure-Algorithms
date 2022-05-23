using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodingProblems.Leetcode
{
    public class CloneGraph
    {
        public GraphNode Clone(GraphNode node)
        {
            HashSet<GraphNode> seen = new HashSet<GraphNode>();
            Queue<GraphNode> queue = new Queue<GraphNode>();
            Dictionary<GraphNode, GraphNode> map = new Dictionary<GraphNode, GraphNode>();
            GraphNode ansNode = new GraphNode(node.val);
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                GraphNode p = queue.Dequeue();
                if (!map.ContainsKey(p))
                    map.Add(p, new GraphNode(p.val));
                seen.Add(p);
                foreach (GraphNode neighbor in p.neighbors)
                {
                    if (seen.Contains(neighbor)) continue;
                    if (!map.ContainsKey(neighbor))
                        map.Add(neighbor, new GraphNode(neighbor.val));
                    map[p].neighbors.Add(map[neighbor]);
                    map[neighbor].neighbors.Add(map[p]);
                    queue.Enqueue(neighbor);
                }
            }
            return ansNode;
        }
    }
}
