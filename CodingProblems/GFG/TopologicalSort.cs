using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.GFG
{
    public class TopologicalSort
    {
        public List<int> TopoSort(int V, List<List<int>> adj)
        {
            bool[] isMarked = new bool[V];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < V; i++)
            {
                if (!isMarked[i]) DFS(i, isMarked, adj,stack);
            }

            return stack.ToList();
        }

        private void DFS(int v, bool[] isMarked, List<List<int>> adj,Stack<int> stack)
        {
            isMarked[v] = true;
            foreach (int w in adj[v])
            {
                if(!isMarked[w])
                    DFS(w,isMarked,adj,stack);
            }
            stack.Push(v);
        }
    }
}
