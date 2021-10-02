using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace Algorithms.Leetcode
{
    public class BinaryTreePaths
    {
        public static IList<string> GetBinaryTreePaths(TreeNode root)
        {
            StringBuilder sb = new StringBuilder(root.val.ToString());
            IList<string> res = new List<string>();
            BinaryTreePathHelper(root.left, res, sb);
            BinaryTreePathHelper(root.right, res, sb);
            return res;
        }

        public static void BinaryTreePathHelper(TreeNode root, IList<string> res, StringBuilder path)
        {
            if (root == null) return;
            string thisPath = "->" + root.val;
            int newPathStartingIndex = path.Length;
            path.Append(thisPath);
            if (root.left == null && root.right == null) res.Add(path.ToString());
            BinaryTreePathHelper(root.left,res,path);
            BinaryTreePathHelper(root.right,res,path);
            path.Remove(newPathStartingIndex, thisPath.Length);
        }

    }
}
