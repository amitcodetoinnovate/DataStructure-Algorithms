using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class GraphValidTree
    {
        public static bool ValidTree(int n, int[][] edges)
        {
            Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
                adj.Add(i, new List<int>());
            for (int i = 0; i < edges.Length; i++)
            {
                int u = edges[i][0];
                int v = edges[i][1];
                adj[u].Add(v);
                adj[v].Add(u);
            }

            Dictionary<int, int> parent = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            parent.Add(0,-1);
            while (stack.Count>0)
            {
                int node = stack.Pop();
                foreach (int neighbour in adj[node])
                {
                    if(parent[node]==neighbour)
                        continue;
                    if (parent.ContainsKey(neighbour))
                        return false;
                    stack.Push(neighbour);
                    parent.Add(neighbour,node);
                }
            }

            return parent.Count == n;
        }
    }
}
