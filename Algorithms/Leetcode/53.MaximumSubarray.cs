using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class MaximumSubarray
    {
        public static int Solve(int[] nums)
        {
            int max = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int tSum = nums[i] + sum;
                if (tSum < 0)
                {
                    sum = 0;
                }
                else
                {
                    sum = tSum;
                    max = Math.Max(tSum, max);
                }
            }
            return sum;
        }

    }
}
