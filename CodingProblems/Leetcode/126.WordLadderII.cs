using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class WordLadderII
    {
        public static IList<IList<string>> FindLadder(string beginWord, string endWord, IList<string> wordList)
        {
            IList<IList<string>> res = new List<IList<string>>();
            Dictionary<string, List<string>> adj = new Dictionary<string, List<string>>();
            Dictionary<string, int> isVisited = new Dictionary<string, int>();
            HashSet<string> set = new HashSet<string>();
            foreach (var t in wordList)
                set.Add(t);
            Queue<string> q = new Queue<string>();
            q.Enqueue(beginWord);
            isVisited.Add(beginWord, 0);
            while (q.Count != 0)
            {
                string curr = q.Dequeue();
                StringBuilder sb = new StringBuilder(curr);
                for (int i = 0; i < curr.Length; i++)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        if (c == curr[i])
                            continue;
                        sb[i] = c;
                        string x = sb.ToString();
                        if (set.Contains(x))
                        {
                            if (!isVisited.ContainsKey(x))
                            {
                                isVisited.Add(x, isVisited[curr] + 1);
                                q.Enqueue(x);
                                if (!adj.ContainsKey(curr))
                                    adj.Add(curr, new List<string> { x });
                                else
                                    adj[curr].Add(x);
                            }
                            else if (isVisited[x] == isVisited[curr] + 1)
                            {
                                if (!adj.ContainsKey(curr))
                                    adj.Add(curr, new List<string> { x });
                                else
                                    adj[curr].Add(x);
                            }
                        }
                    }
                    sb[i] = curr[i];
                }
            }
            DFS(beginWord, endWord, adj, res, new LinkedList<string>());
            return res;
        }

        private static void DFS(string beginWord, string endWord, Dictionary<string, List<string>> adj, IList<IList<string>> res, LinkedList<string> ts)
        {
            ts.AddLast(beginWord);
            
            if (beginWord.Equals(endWord))
            {
                res.Add(new List<string>(ts));
                ts.RemoveLast();
                return;
            }

            if (!adj.ContainsKey(beginWord))
            {
                ts.RemoveLast();
                return;
            }
            
            foreach (string bWord in adj[beginWord])
            {
                DFS(bWord, endWord, adj, res, ts);
            }
            ts.RemoveLast();
        }
    }
}
