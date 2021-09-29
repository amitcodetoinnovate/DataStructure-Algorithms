using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
//https://practice.geeksforgeeks.org/problems/height-of-binary-tree/1

namespace Algorithms.GFG
{
    public class HeightOfBinaryTree
    {
        private int D(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(D(root.left) + 1, D(root.right) + 1);
        }
    }
}
