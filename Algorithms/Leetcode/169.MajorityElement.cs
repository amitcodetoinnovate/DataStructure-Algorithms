using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class MajorityElement
    {
        public static int FindMajorityElement(int[] nums)
        {
            Array.Sort(nums);
            int i = 0;
            int mCount = nums.Length / 2;
            while (i < nums.Length)
            {
                int j = BS(nums, i, nums.Length - 1, nums[i]);
                if (j != -1)
                {
                    if ((j - i + 1) > mCount)
                    {
                        return nums[i];
                    }
                    i = j + 1;
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }

        private static int BS(int[] nums, int lo, int hi, int key)
        {
            int i = -1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (nums[mid] > key)
                {
                    hi = mid - 1;
                }
                else
                {
                    i = mid;
                    lo = mid + 1;
                }
            }
            return i;
        }
    }
}
