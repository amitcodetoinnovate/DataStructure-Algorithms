using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class NextPermutation
    {
        public static void NextPemute(int[] nums)
        {
            int i = nums.Length-1;
            while (i > 0)
            {
                if (nums[i-1] < nums[i])
                {
                    break;
                }
                i--;
            }
            i = i - 1;
            if (i == -1)
            {
                ReverseArray(nums, 0);
            }
            else
            {
                int numToSwap = nums[i];
                int j = nums.Length-1;
                while (j >= 0)
                {
                    if (numToSwap < nums[j])
                    {
                        Swap(i, j, nums);
                        ReverseArray(nums, i + 1);
                        break;
                    }
                    j--;
                }
            }
        }

        private static void ReverseArray(int[] nums, int v)
        {
            for (int i = v, j = nums.Length-1; i < j; i++, j--)
            {
                Swap(i, j, nums);
            }
        }

        private static void Swap(int i, int j, int[] nums)
        {
           var temp =nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public static void BadApproach(int[] nums)
        {
            
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> curse = new List<int>(nums);
            Array.Sort(nums);
            IList<int> iter = new List<int>(nums);
            Permute(res, iter, new List<int>());
            for (int i = 0; i < res.Count; i++)
            {
                if (IsMatched(res[i], curse))
                {
                    if (i == res.Count - 1)
                    {
                        for (int j = 0; j < nums.Length; j++)
                        {
                            nums[j] = res[i - 1][j];
                        }
                    }
                    else
                    {
                        for (int j = 0; j < nums.Length; j++)
                        {
                            nums[j] = res[i + 1][j];
                        }
                    }
                }
            }
        }
        private static bool IsMatched(IList<int> res, IList<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] != res[i]) return false;
            }
            return true;
        }

        private static void Permute(IList<IList<int>> res, IList<int> list, IList<int> temp)
        {
            if (list.Count == 0)
            {
                res.Add(new List<int>(temp));
                return;
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int value = list[i];
                    list.RemoveAt(i);
                    temp.Add(value);
                    Permute(res, list, temp);
                    list.Insert(i, value);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
    }
}
