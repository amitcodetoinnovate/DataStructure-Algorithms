using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodingProblems.Leetcode
{
    public class SymmetricTree
    {
        public static bool SolveRecursive1(TreeNode root)
        {
            Dictionary<int, List<TreeNode>> left = new Dictionary<int, List<TreeNode>>();
            Dictionary<int, List<TreeNode>> right = new Dictionary<int, List<TreeNode>>();
            FillList(root.left, 0, left);
            FillList(root.right, 0, right);
            return Validate(left, right);
        }


        public static bool SolveRecursive2(TreeNode t1,TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return true;
            if (t1 == null || t2 == null)
                return true;
            return t1.val == t2.val && SolveRecursive2(t1.left, t2.right) && SolveRecursive2(t1.right, t2.left);
        }

        public static bool SolveIterative(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(root);
            while (q.Count!=0)
            {
                TreeNode t1 = q.Dequeue();
                TreeNode t2 = q.Dequeue();
                if (t1 == null && t2 == null) continue;
                if (t1 == null || t2 == null) return false;
                if (t1.val != t2.val) return false;
                q.Enqueue(t1.left);
                q.Enqueue(t2.right);
                q.Enqueue(t1.right);
                q.Enqueue(t2.left);
            }
            return true;
        }

        private static void FillList(TreeNode root, int level, Dictionary<int, List<TreeNode>> list)
        {
            if (root == null)
            {
                if (!list.ContainsKey(level))
                    list.Add(level, new List<TreeNode> { root });
                else
                    list[level].Add(root);
                return;
            }

            FillList(root.left, level + 1, list);
            if (!list.ContainsKey(level))
                list.Add(level, new List<TreeNode> { root });
            else
                list[level].Add(root);
            FillList(root.right, level + 1, list);
        }

        private static bool Validate(Dictionary<int, List<TreeNode>> left, Dictionary<int, List<TreeNode>> right)
        {
            for (int i = 0; i < Math.Max(left.Count, right.Count); i++)
            {
                if (!left.ContainsKey(i) || !right.ContainsKey(i)) return false;
                if (left[i].Count != right[i].Count) return false;
                for (int j = 0; j < Math.Max(left[i].Count, right[i].Count); j++)
                {
                    var l = left[i][left[i].Count - 1 - j];
                    var r = right[i][j];
                    if ((r == null && l != null) || (r != null && l == null)) return false;
                    if (r != null && l != null && (r.val != l.val)) return false;
                }
            }

            return true;
        }
    }
}
