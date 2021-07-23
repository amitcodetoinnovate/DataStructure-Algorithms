/// <summary>
/// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
/// </summary>
namespace Algorithms.Leetcode
{
    public class RemoveDuplicate
    {
        public static int RemoveDuplicatesSol(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[k] != nums[i])
                    nums[++k] = nums[i];
            }
            return k + 1;
        }
    }
}
