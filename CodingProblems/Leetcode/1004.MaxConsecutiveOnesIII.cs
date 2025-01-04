using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class MaxConsecutiveOnesIII
    {
        public static int LongestOnes(int[] nums, int k)
        {
            int i = 0, j = 0, max = 0, temp = k;
            while (i < nums.Length)
            {
                if (nums[i] == 1)
                {
                    i++;
                    max = Math.Max(max, i - j);
                }
                else
                {
                    if (temp > 0 && temp <= k)
                    {
                        temp--;
                        i++;
                        max = Math.Max(max, i - j);
                    }
                    else
                    {
                        if (i == j)
                        {
                            i++;
                            j++;
                        }
                        else
                        {
                            while (nums[j++] != 0 && j < i) { }
                            if (temp < k)
                                temp++;
                        }
                    }
                }
            }
            return max;
        }
    }
}
