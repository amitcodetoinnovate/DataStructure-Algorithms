//https://leetcode.com/problems/most-common-word/
using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public class MostCommonWord
    {

        public static string Solve(string paragraph, string[] banned)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            HashSet<string> ban = new HashSet<string>();
            HashSet<char> ignore = new HashSet<char>();
            string answer = "";
            int count = 0;
            ignore.Add(' ');
            ignore.Add(',');
            ignore.Add('?');
            ignore.Add('!');
            ignore.Add('\'');
            ignore.Add(';');
            ignore.Add('.');
            for (int k = 0; k < banned.Length; k++)
                ban.Add(banned[k]);

            int i = 0;
            while (i < paragraph.Length)
            {
                if (ignore.Contains(paragraph[i]))
                {
                    i++;
                    continue;
                }
                int j = i;
                while (j < paragraph.Length)
                {
                    if (ignore.Contains(paragraph[j]))
                        break;
                    j++;
                }
                string s = paragraph.Substring(i, j - i).ToLower();
                if (ban.Contains(s))
                {
                    i = j + 1;
                    continue;
                }
                if (!map.ContainsKey(s))
                {
                    map.Add(s, 1);
                    if (count == 0)
                    {
                        count = 1;
                        answer = s;
                    }
                }
                else
                {
                    map[s]++;
                    if (map[s] > count)
                    {
                        count = map[s];
                        answer = s;
                    }
                }
                i = j + 1;
            }
            return answer;
        }
    }
}
