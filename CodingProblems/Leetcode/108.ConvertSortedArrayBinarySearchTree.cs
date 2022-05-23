using DataStructures;
//https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/

namespace CodingProblems.Leetcode
{
    public class ConvertSortedArrayBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedHelper(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedHelper(int[] nums, int lo, int hi)
        {
            if (lo > hi) return null;
            if (lo == hi) return new TreeNode(nums[lo]);
            int mid = lo + (hi - lo) / 2;
            return new TreeNode(nums[mid], SortedHelper(nums, lo, mid - 1), SortedHelper(nums, mid + 1, hi));
        }
    }
}
