using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.GFG
{
    public class DetectCycleInADirectedGraph
    {
        public bool IsCyclic(int V, List<List<int>> adj)
        {
            bool[] marked = new bool[V];
            bool[] onStack = new bool[V];
            for (int v = 0; v < V; v++)
            {
                if (!marked[v])
                {
                    if (DFS(v, adj, marked, onStack)) return true;
                }
            }
            return false;
        }

        private bool DFS(int v, List<List<int>> adj, bool[] marked, bool[] onStack)
        {
            marked[v] = true;
            onStack[v] = true;
            foreach (int w in adj[v])
            {
                if (!marked[w])
                {
                    if (DFS(w, adj, marked, onStack)) return true;
                }
                else if (onStack[w]) return true;

            }
            onStack[v] = false;
            return false;
        }
    }
}
