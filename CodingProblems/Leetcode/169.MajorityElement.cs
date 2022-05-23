using System;
// https://leetcode.com/problems/majority-element/
namespace CodingProblems.Leetcode
{
    public class MajorityElement
    {
        public int MajorityElementBest(int[] nums)
        {
            int candidate = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    if (count == 1)
                    {
                        candidate = nums[i];
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            return candidate;
        }
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
