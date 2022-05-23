//https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters/
using System;

namespace CodingProblems.Leetcode
{

    public class LengthOfLongestSubstringTwoDistinct
    {
        public static int Solve(string s)
        {
            int[] map = new int[2] { -1, -1 };
            int[] count = new int[2];
            int[] lastOcc = new int[2];
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int v = (int)s[i];
                int occ = IsPresentInMap(map, v);
                if (occ != -1)
                {
                    lastOcc[occ] = i;
                    count[occ]++;
                    res = Math.Max(res, count[0] + count[1]);
                }
                else
                {
                    if (IsAnyEmpty(map))
                    {
                        map[map[0] == -1 ? 0 : 1] = s[i];
                        lastOcc[map[0] == -1 ? 0 : 1] = i;
                        count[map[0] == -1 ? 0 : 1]++;
                        res = Math.Max(res, count[0] + count[1]);
                    }
                    else
                    {
                        int m = lastOcc[0] < lastOcc[1] ? 0 : 1;
                        count[lastOcc[0] < lastOcc[1] ? 1 : 0] = i - lastOcc[m] - 1;
                        map[m] = v;
                        lastOcc[m] = i;
                        count[m] = 1;
                    }
                }
            }
            return res;
        }

        private static int IsPresentInMap(int[] map, int v)
        {
            if (map[0] == v)
                return 0;
            if (map[1] == v)
                return 1;
            return -1;
        }

        private static bool IsAnyEmpty(int[] map)
        {
            if (map[0] == -1 || map[1] == -1)
                return true;
            else
                return false;
        }
    }
}
