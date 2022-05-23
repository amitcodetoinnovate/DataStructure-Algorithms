using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.GFG
{
    public class NMeetingsInOneRoom
    {
        public static int MaxMeetings(int[] start, int[] end, int n)
        {

            List<int[]> met = new List<int[]>();
            for (int i = 0; i < n; i++)
                met.Add(new int[] { start[i], end[i] });
            met.Sort((a, b) => a[1].CompareTo(b[1]) == 0 ? a[0].CompareTo(b[0]) : a[1].CompareTo(b[1]));
            int count = 1;
            int prevEnd = met[0][1];
            for (int i = 1; i < n; i++)
            {
                if (met[i][0] > prevEnd)
                {
                    count++;
                    prevEnd = met[i][1];
                }
            }
            return count;
        }
    }
}
