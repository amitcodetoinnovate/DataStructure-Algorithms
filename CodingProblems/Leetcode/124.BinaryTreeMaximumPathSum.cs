using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodingProblems.Leetcode
{
    public class BinaryTreeMaximumPathSum
    {
        private static int max = 0;
        public int MaxPathSum(TreeNode root)
        {
            max = Int32.MinValue;
            var x = PSum(root);
            return max;
        }
        private int PSum(TreeNode root)
        {
            if (root == null) return 0;
            int left = Math.Max(0, PSum(root.left));
            int right = Math.Max(PSum(root.right), 0);
            max = Math.Max(max, left + right + root.val);
            return Math.Max(left, right) + root.val;
        }
    }
}
