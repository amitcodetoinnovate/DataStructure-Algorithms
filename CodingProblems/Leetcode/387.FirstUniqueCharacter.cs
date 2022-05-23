using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class FirstUniqueCharacter
    {
        public static int Solve(string s)
        {
            int j = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], i);
                    count.Add(s[i], 1);
                }
                else
                {
                    count[s[i]]++;
                    if (j == map[s[i]])
                    {
                        j++;
                        while (j < s.Length && map.ContainsKey(s[j]) && count[s[j]] != 1) { j++; }
                    }
                }
            }
            return j > s.Length - 1 ? -1 : j;
        }
    }
}
