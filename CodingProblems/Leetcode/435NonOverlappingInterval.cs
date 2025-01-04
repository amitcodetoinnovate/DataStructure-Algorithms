using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class _435NonOverlappingInterval
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]) == 0 ? (x[0].CompareTo(y[0])) : (x[1].CompareTo(y[1])));
            int i = 0, c = 0, j = 1;
            while (i < intervals.Length && j < intervals.Length)
            {
                if (intervals[i][1] <= intervals[j][0])
                {
                    c++;
                    j++;
                }
                else
                {
                    i = j++;
                }
            }
            return c;
        }
    }
}
