//https://leetcode.com/problems/longest-substring-without-repeating-characters/
using System;
using System.Collections.Generic;


namespace Algorithms.Leetcode
{
    public class LongestNonRepeatingSubsequence
    {
        public static int Solve(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int max = Int32.MinValue;
            int i = 0, j = 0;
            while (i < s.Length && j < s.Length)
            {
                if (!map.ContainsKey(s[i]) || (map.ContainsKey(s[i]) && map[s[i]] < j))
                {
                    max = Math.Max(max, i - j + 1);
                    if (!map.ContainsKey(s[i]))
                        map.Add(s[i], i);
                    else
                        map[s[i]] = i;
                    i++;
                }
                else
                {
                    j = map[s[i]] + 1;
                    map[s[i]] = i;
                    i++;

                }
            }
            return max;
        }
    }
}
