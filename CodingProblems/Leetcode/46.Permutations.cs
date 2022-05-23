using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            PermuteHelper(new List<int>(nums), new List<int>(), res);
            return res;
        }
        private static void PermuteHelper(List<int> nums, List<int> choosen, IList<IList<int>> res)
        {
            if (nums.Count == 0)
                res.Add(new List<int>(choosen));
            else
            {
                
                for (int i = 0; i < nums.Count; i++)
                {
                    choosen.Add(nums[i]);
                    nums.RemoveAt(i);
                    PermuteHelper(nums, choosen, res);
                    nums.Insert(i, choosen[choosen.Count - 1]);
                    choosen.RemoveAt(choosen.Count - 1);
                }

            }
        }
    }
}
