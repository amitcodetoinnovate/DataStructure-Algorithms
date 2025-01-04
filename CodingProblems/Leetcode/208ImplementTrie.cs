using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class Trie
    {
        private Node _trie;
        public Trie()
        {
            _trie = new Node();
            _trie.characters = new Node[26];
            _trie.isFinished = true;
        }

        public void Insert(string word)
        {
            Node n = _trie;
            foreach (char c in word)
            {
                if (n.characters[c - 'a'] == null)
                    n.characters[c - 'a'] = new Node();
                n = n.characters[c - 'a'];
            }
            n. isFinished= true;
        }

        public bool Search(string word)
        {
            Node n = _trie;
            foreach (char c in word)
            {
                if (n.characters[c - 'a'] == null)
                    return false;
                n = n.characters[c - 'a'];
            }
            return n.isFinished;

        }

        public bool StartsWith(string prefix)
        {
            Node n = _trie;
            var f = new StringBuilder();
            f.Remove(0, prefix.Length);
            foreach (char c in prefix)
            {
                if (n.characters[c - 'a'] == null)
                    return false;
                n = n.characters[c - 'a'];
            }
            return true;
        }
        public class Node
        {
            public Node()
            {
                characters = new Node[26];
            }
            public Node[] characters;
            public bool isFinished;
        }
    }
    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
