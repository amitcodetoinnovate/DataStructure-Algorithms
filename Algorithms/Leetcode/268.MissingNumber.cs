//https://leetcode.com/problems/missing-number/

namespace Algorithms.Leetcode
{
    public class MissingNumber
    {
        public static int Solve(int[] nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
                k = k ^ nums[i] ^ (i + 1);
            return k;
        }
    }
}
