using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class WordLadder
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            Dictionary<string, List<string>> adj = new Dictionary<string, List<string>>();
            Dictionary<string, bool> isVisited = new Dictionary<string, bool>();
            Queue<string> q = new Queue<string>();

            adj.Add(beginWord, new List<string>());

            for (int i = 0; i < wordList.Count; i++)
                if (IsDiffOne(wordList[i], beginWord)) adj[beginWord].Add(wordList[i]);

            for (int i = 0; i < wordList.Count; i++)
            {
                List<string> t = new List<string>();
                isVisited.Add(wordList[i], false);
                foreach (var t1 in wordList)
                    if (IsDiffOne(wordList[i], t1))
                        t.Add(t1);

                adj.Add(wordList[i], t);
            }
            if (!adj.ContainsKey(endWord))
                return 0;
            int c = 0;
            q.Enqueue(beginWord);
            isVisited[beginWord] = true;

            while (q.Count != 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    string el = q.Dequeue();
                    foreach (string word in adj[el])
                    {
                        if (!isVisited[word])
                        {
                            if (word.Equals(endWord))
                            {
                                return c + 2;
                            }
                            isVisited[word] = true;
                            q.Enqueue(word);
                        }
                    }

                }
                c++;
            }
            return 0;
        }

        private static bool IsDiffOne(string fWord, string sWord)
        {
            int c = 0;
            for (int i = 0; i < fWord.Length; i++)
            {
                if (fWord[i] != sWord[i])
                    c++;
            }
            return c == 1;
        }

    }
}
