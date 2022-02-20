using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class Sol
    {
        public static int Solution(int[] A)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int k = 0; k < A.Length; k++)
            {
                if (!map.ContainsKey(A[k]))
                {
                    map.Add(A[k], 1);
                }
                else
                {
                    map[A[k]]++;
                }
            }
            int i = 0;
            int j = 0;
            int s = 0;
            int ans = Int32.MaxValue;
            Dictionary<int, int> reduce = new Dictionary<int, int>();
            while (j <= i && i < A.Length)
            {
                if (s < map.Count)
                {
                    if (!reduce.ContainsKey(A[i]) || reduce[A[i]] == 0)
                    {
                        if (!reduce.ContainsKey(A[i]))
                        {
                            reduce.Add(A[i], 1);
                            s++;
                        }
                        else
                        {
                            reduce[A[i]]++;
                            s++;
                        }
                    }
                    else
                    {
                        reduce[A[i]]++;
                    }

                    if (s == map.Count)
                    {
                        ans = Math.Min(ans, i - j + 1);
                    }
                    else
                    {

                    i++;
                    }
                }
                else
                {
                    if (reduce[A[j]] > 1)
                    {
                        reduce[A[j]]--;
                        j++;
                        ans = Math.Min(ans, i - j + 1);
                    }
                    else if (reduce[A[j]] == 1)
                    {
                        reduce[A[j]]--;
                        j++;
                        s--;
                    }
                }
            }
            return ans;
        }
    }
}
