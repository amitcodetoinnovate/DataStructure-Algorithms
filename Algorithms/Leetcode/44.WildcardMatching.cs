using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class WildcardMatching
    {
        public static bool IsMatch(string s, string p)
        {
            return MatchHelper(p, 0, s, 0);
        }

        private static bool MatchHelper(string p, int i, string s, int j)
        {
            if (i >= p.Length && j >= s.Length) return true;
            if (i < p.Length || j > s.Length) return false;
            if (p[i] == '*')
            {
                int k = i;
                while (p[k] == '*')
                {
                    k++;
                }

                if (k != i) i = k - 1;
                    return MatchHelper(p, i + 1, s, j) || MatchHelper(p, i, s, j + 1) || MatchHelper(p, i + 1, s, j + 1);
            }
            else if (p[i] == '?')
            {
                return MatchHelper(p, i + 1, s, j + 1);
            }
            else
            {
                if (p[i] == s[j]) return MatchHelper(p, i + 1, s, j + 1);
                return false;
            }
        }
    }
}
