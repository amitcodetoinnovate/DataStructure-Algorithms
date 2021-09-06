﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            for (int i = 0; i < intervals.Length; i++)
            {
                Console.WriteLine(intervals[i][0] + ", " + intervals[i][1]);
            }
            List<int[]> list = new List<int[]>();
            int n = intervals.Length;
            for (int i = 0; i < intervals.Length; i++)
            {
                if (i + 1 < n)
                {
                    if (intervals[i][1] >= intervals[i + 1][0])
                    {
                        list.Add(new int[] { intervals[i][0], intervals[i + 1][1] });
                        i++;
                    }
                    else
                    {
                        list.Add(new int[] { intervals[i][0], intervals[i][1] });
                    }


                }
                else
                {
                    list.Add(new int[] { intervals[i][0], intervals[i][1] });
                }
            }
            int[][] res = new int[list.Count][];
            for (int i = 0; i < list.Count; i++)
            {
                res[i] = new int[] { list[i][0], list[i][1] };
            }
            return res;
        }

    }
}
