using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class ProductExceptSelf
    {
        public static int[] Solve(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int prod = 1, countZeroes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    prod = prod * nums[i];
                else
                    countZeroes++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (countZeroes == 0)
                {
                    ans[i] = prod / nums[i];
                }
                else if (countZeroes > 1)
                {
                    ans[i] = 0;
                }
                else
                {
                    ans[i] = nums[i] == 0 ? prod : 0;
                }
            }
            return ans;
        }
    }
}
