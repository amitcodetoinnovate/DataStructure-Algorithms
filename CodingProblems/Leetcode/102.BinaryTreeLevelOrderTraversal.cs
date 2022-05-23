using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodingProblems.Leetcode
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            if (root != null)
                q.Enqueue(root);
            while (q.Count != 0)
            {
                int count = q.Count;
                List<int> level = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    TreeNode c = q.Dequeue();
                    level.Add(c.val);
                    if (c.left != null)
                        q.Enqueue(c.left);
                    if (c.right != null)
                        q.Enqueue(c.right);
                }
                list.Add(level);
            }
            return list;
        }

        public IList<IList<int>> LevelOrderRecursive(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            LO(root, 0, list);
            return list;
        }

        private void LO(TreeNode root, int level, IList<IList<int>> list)
        {
            if (list.Count == level)
                list.Add(new List<int> { root.val });
            else
                list[level].Add(root.val);
            if (root.left != null)
                LO(root.left, level + 1, list);
            if (root.right != null)
                LO(root.right, level + 1, list);
        }
    }
}
