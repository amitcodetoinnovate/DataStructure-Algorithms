using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class ReorganizeString
    {
        public string Solve(string str)
        {
            int[] arr = new int[26];

            for (int i = 0; i < str.Length; i++)
                arr[str[i] - 'a']++;

            StringBuilder builder = new StringBuilder();

            var count = str.Length;

            while (count > 0)
            {
                int item = GetMaxChar(arr, -1), next; //获取出现次数最多的char

                if (arr[item] == 1) //如果次数为1直接添加
                {
                    builder.Append((char)(item + 'a'));
                    arr[item]--;
                    count--;
                }
                else
                {
                    builder.Append((char)(item + 'a'));
                    next = GetMaxChar(arr, item); //找出第二个出现次数最多的char
                    if (next == -1)
                        return string.Empty; //若没有则无法成功

                    builder.Append((char)(next + 'a'));
                    arr[item]--;
                    arr[next]--;
                    count -= 2;
                }
            }

            return builder.ToString();
        }

        private int GetMaxChar(int[] arr, int compare)
        {
            var max = -1;
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) continue;
                if (i == compare) continue;
                if (arr[i] > count)
                {
                    max = i;
                    count = arr[i];
                }
            }

            return max;
        }

    }
}
