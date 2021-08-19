//https://leetcode.com/problems/validate-binary-search-tree/

using System;
using System.Collections.Generic;
using DataStructures;

namespace Algorithms.Leetcode
{
    public class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            return B(root, null, null);
        }

        public bool B(TreeNode root, int? lo, int? hi)
        {
            if (root == null) return true;
            if ((lo != null && root.val <= lo) || (hi != null && root.val >= hi))
                return false;
            return B(root.left, lo, root.val) && B(root.right, root.val, hi);
        }
        public bool IsValid(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            int leftCV = Int32.MinValue;
            while (s.Count != 0 || root != null)
            {
                while (root != null)
                {
                    s.Push(root);
                    root = root.left;
                }
                root = s.Pop();
                if (root.val <= leftCV) return false;
                leftCV = root.val;
                root = root.right;
            }
            return true;
        }
    }
}
