//https://leetcode.com/problems/minimum-window-substring/
using System.Collections.Generic;
namespace Algorithms.Leetcode
{
    public class MinimumWindowSubstring
    {
        public static string Solve(string s, string t)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int k = 0; k < t.Length; k++)
            {
                if (map.ContainsKey(t[k]))
                    map[t[k]]++;
                else
                    map.Add(t[k], 1);
            }
            int i = 0, j = 0, l = 0, r = s.Length;
            int c = map.Count;
            bool f = false;
            while (i < s.Length)
            {
                char endChar = s[i++];
                if (c > 0)
                {
                    if (map.ContainsKey(endChar))
                        map[endChar]--;
                    if (map.ContainsKey(endChar) && map[endChar] == 0)
                        c--;
                }

                if (c == 0)
                {
                    while (c == 0)
                    {
                        f = true;
                        if (i - j < r - l)
                        {
                            r = i;
                            l = j;
                        }

                        if (map.ContainsKey(s[j]))
                            map[s[j]]++;

                        if (map.ContainsKey(s[j]) && map[s[j]] > 0)
                            c++;
                        j++;
                    }
                }
            }
            return f ? s.Substring(l, r - l) : "";
        }
    }
}