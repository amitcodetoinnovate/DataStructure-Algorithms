using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class Solution
    {
        private Node node;
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            node = new Node();
            var result = new List<IList<string>>();
            foreach (string p in products)
            {
                Insert(p);
            }
            StringBuilder sb = new StringBuilder();
            foreach (char c in searchWord)
            {
                sb.Append(c);
                var l = FindTopThreeMatching(sb);
                if (l.Count > 0)
                    result.Add(l);
            }
            return result;
        }

        private List<string> FindTopThreeMatching(StringBuilder sb)
        {
            String s = sb.ToString();
            List<string> list = new List<string>();
            Node n = null;
            foreach (char c in s)
            {
                if (node.characters[c - 'a'] == null)
                {
                    return list;
                }
                n = node.characters[c - 'a'];
            }
            int x = 0;
            AddWords(n, ref x, list, new StringBuilder(s));
            return list;

        }
        private void AddWords(Node n, ref int x, List<string> list, StringBuilder sb)
        {
            if (x > 2 || n == null) return;
            if (n.isWord)
            {
                list.Add(sb.ToString());
                x++;
            }
            for (int i = 0; i < n.characters.Length; i++)
            {
                if (n.characters[i] != null)
                {
                    sb.Append(Convert.ToChar(i + 97));
                    AddWords(n.characters[i], ref x, list, sb);
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }

        private void Insert(string word)
        {
            Node n = node;
            foreach (char c in word)
            {
                if (n.characters[c - 'a'] == null)
                    n.characters[c - 'a'] = new Node();
                n = n.characters[c - 'a'];
            }
            n.isWord = true;
        }

        public class Node
        {
            public Node[] characters;
            public bool isWord;
            public Node()
            {
                characters = new Node[26];
            }
        }
    }
}
