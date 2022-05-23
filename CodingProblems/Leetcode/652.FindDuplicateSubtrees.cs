using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
//https://leetcode.com/problems/find-duplicate-subtrees/

namespace CodingProblems.Leetcode
{
    public class FindDuplicateSubtrees
    {
        public IList<TreeNode> Solve(TreeNode root)
        {
            IList<TreeNode> list = new List<TreeNode>();
            var map = new Dictionary<string, int>();
            F(root, map, list);
            return list;
        }
        private string F(TreeNode root, Dictionary<string, int> map, IList<TreeNode> list)
        {
            if (root == null) return "X";
            string key = "(" + F(root.left, map, list) + root.val + F(root.right, map, list) + ")";
            if (map.ContainsKey(key))
            {
                if (map[key] > 1)
                {
                    map[key]++;
                }
                else
                {
                    map[key]++;
                    list.Add(root);
                }
            }
            else
            {
                map.Add(key, 1);
            }
            return key;

        }
    }
}
