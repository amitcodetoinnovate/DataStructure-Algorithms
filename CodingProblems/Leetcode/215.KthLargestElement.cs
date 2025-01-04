using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class KThLargestElement
    {
        public void FindKthLargest(int[] nums,int k)
        {
            //PriorityQueue<int,int> priorityQueue = new PriorityQueue<int, int>(new comp());
            PriorityQueue<(int, int), (int, int)> priorityQueue = new PriorityQueue<(int,int), (int,int)>(new comp());
            int[] ints = new int[] { 3, 2, 1, 5, 6, 4 };
            foreach(int i in ints)
            {
                priorityQueue.Enqueue((i,1), (i, 1));
            }
            priorityQueue.Peek();
            List<int> res = new List<int>();
            while (priorityQueue.Count > 0) {
                //res.Add(priorityQueue.Dequeue());
            };
        }
    }

    public class comp : IComparer<(int,int)>
    {
        public int Compare((int,int) x, (int,int) y)
        {
            return x.Item1.CompareTo(y.Item1) == 0 ? (x.Item2.CompareTo(y.Item2)) : x.Item1.CompareTo(y.Item1);
        }
    }
    
}
